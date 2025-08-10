using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        string input;
        do
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goal Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option from the menu: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;

                case "2":
                    Console.WriteLine("\nYour Goals:");
                    goalManager.ListGoalDetails();
                    break;

                case "3":
                    Console.Write("Enter the file name to save goals (or press Enter for 'goals.txt'): ");
                    string saveFileName = Console.ReadLine();
                    if (string.IsNullOrEmpty(saveFileName))
                    {
                        saveFileName = "goals.txt";
                    }
                    goalManager.SaveGoals(saveFileName);
                    Console.WriteLine($"Goals saved to {saveFileName}");
                    break;

                case "4":
                    Console.Write("Enter the file name to load goals (or press Enter for 'goals.txt'): ");
                    string loadFileName = Console.ReadLine();
                    if (string.IsNullOrEmpty(loadFileName))
                    {
                        loadFileName = "goals.txt";
                    }
                    goalManager.LoadGoals(loadFileName);
                    Console.WriteLine($"Goals loaded from {loadFileName}");
                    break;

                case "5":
                    goalManager.RecordEvent();
                    Console.WriteLine($"Current Score: {goalManager.GetScore()}");
                    goalManager.DisplayPlayerInfo();
                    break;

                case "6":
                    Console.WriteLine("Thanks for playing Eternal Quest! Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        } while (input != "6");
    }
}