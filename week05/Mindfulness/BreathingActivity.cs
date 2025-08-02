using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description)
    {
        // name = "Breathing Activity";
        // description = "This activity will help you relax by guiding you through a series of deep breathing exercises.";

    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Now breathe out...");
            ShowCountdown(5);
            Console.WriteLine();
            Thread.Sleep(1000);
        }
    }
}