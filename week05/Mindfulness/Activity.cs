using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write($"Choose a duration for the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        if (_duration <= 0)
        {
            Console.Write("Please enter a valid duration greater than 0.");
            _duration = 30; // Default to 30 seconds if invalid input
        }
        Console.WriteLine($"You have {_duration} seconds to complete this activity.");
        Console.WriteLine("Press enter to start the activity.");
        Console.ReadLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Thank you for participating in the activity!");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { };
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        foreach (var item in spinner)
        {
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    //     DateTime startTime = DateTime.Now;
    //     DateTime endTime = startTime.AddSeconds(10);
    //     while (DateTime.Now < endTime)
    //     {
    //         foreach (var item in spinner)
    //         {
    //             Console.Write(item);
    //             Thread.Sleep(500);
    //             Console.Write("\b \b");
    //         }
    //     }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = 5; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}