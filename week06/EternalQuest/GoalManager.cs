using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
   
    private List<Goal> _goals;
    private int _score;

    
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    
    public void Start()
    {
        LoadGoals();
        DisplayPlayerInfo();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
           Console.WriteLine(goal.GetShortName()); 
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice (1-3): ");
        string typeChoice = Console.ReadLine();
        if (string.IsNullOrEmpty(typeChoice))
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }   

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for the goal: ");
        int points = 0;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out points) && points > 0)
            {
                break; // valid points entered
            }
            Console.Write("Invalid input. Please enter a positive integer for points: ");
        }

        Goal goalToAdd = null;

        switch (typeChoice)
        {
            case "1": // Like an if statement
                goalToAdd = new SimpleGoal(name, description, points);
                break;
            case "2":
                goalToAdd = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target count for checklist: ");
                int targetCount = int.TryParse(Console.ReadLine(), out int tc) ? tc : 1;
                Console.Write("Enter bonus points for completing checklist: ");
                int bonus = int.TryParse(Console.ReadLine(), out int b) ? b : 0;
                goalToAdd = new ChecklistGoal(name, description, points, targetCount, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Simple Goal.");
                goalToAdd = new SimpleGoal(name, description, points);
                break;
        }
        
        _goals.Add(goalToAdd);
        Console.WriteLine("Goal added successfully!");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record an event.");
            return;
        }

        Console.WriteLine("Select a goal to record an event for:");
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {_goals[i].GetShortName()}");
        }

        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            
            // Call the goal's RecordEvent method to handle completion logic
            selectedGoal.RecordEvent();
            
            // Add points to score
            _score += selectedGoal.GetPoints();

            // For ChecklistGoal, add bonus if completed
            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                int bonusPoints = checklistGoal.GetBonus();
                _score += bonusPoints;
                Console.WriteLine($"Bonus points earned: {bonusPoints}");
            }

            Console.WriteLine($"Event recorded for: {selectedGoal.GetShortName()}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public int GetScore()
    {
        return _score;
    }
    
    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Save the score first
            writer.WriteLine($"Score:{_score}");
            
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filePath = "goals.txt")
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No saved goals file found. Starting fresh.");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);
        _goals.Clear();
        
        foreach (string line in lines)
        {
            if (line.StartsWith("Score:"))
            {
                string scoreStr = line.Substring(6); // Remove "Score:" prefix
                if (int.TryParse(scoreStr, out int savedScore))
                {
                    _score = savedScore;
                }
                continue;
            }

            string[] parts = line.Split(':');
            if (parts.Length < 2) continue;

            string goalType = parts[0];
            string[] goalData = parts[1].Split(',');

            try
            {
                switch (goalType)
                {
                    case "SimpleGoal":
                        if (goalData.Length >= 4) 
                        {
                            var simpleGoal = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));

                            if (bool.Parse(goalData[3]))
                            {
                                simpleGoal.RecordEvent();
                            }
                            _goals.Add(simpleGoal);
                        }
                        break;

                    case "EternalGoal":
                        if (goalData.Length >= 3)
                        {
                            _goals.Add(new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2])));
                        }
                        break;

                    case "ChecklistGoal":
                        if (goalData.Length >= 6)
                        {
                            var checklistGoal = new ChecklistGoal(goalData[0], goalData[1], 
                                int.Parse(goalData[2]), int.Parse(goalData[4]), int.Parse(goalData[5]));
                            
                            int amountCompleted = int.Parse(goalData[3]);
                            for (int i = 0; i < amountCompleted; i++)
                            {
                                checklistGoal.RecordEvent();
                            }
                            _goals.Add(checklistGoal);
                        }
                        break;
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Error loading goal from line: {line}. Exception: {ex.Message}");
            }
        }
        Console.WriteLine($"Loaded {_goals.Count} goals.");
    }
}