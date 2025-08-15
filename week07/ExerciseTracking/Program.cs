using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running(5, 10, 6, 30);
        Activity cycling = new Cycling(20, 15, 4, 60);
        Activity swimming = new Swimming(0, 0, 0, 30, 20);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
    
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}