using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();



    public ListingActivity(string name, string description)
        : base(name, description)
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("--Who are people that you appreciate?--");
        _prompts.Add("--What are personal strengths of yours?--");
        _prompts.Add("--Who are people that you have helped this week?--");
        _prompts.Add("--When have you felt the Holy Ghost this month?--");
        _prompts.Add("--Who are some of your personal heroes?--");
        _count = 0;

    }

    public void Run()
    {
        Console.WriteLine("Here is your prompt:");
        GetRandomPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("Please enter your items (type 'done' when finished):");
        Console.Write("- ");
        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                Console.Write("- ");
                userList.Add(input);
                _count++; 
            }
        }

        using (StreamWriter writer = new StreamWriter("List.txt", true))
        {
            foreach (string i in userList)
            {
                writer.WriteLine("- " + i);
            }
        }
        
        Console.WriteLine($"You listed {_count} items.");
        Console.WriteLine();
        return userList;
        
    }
}