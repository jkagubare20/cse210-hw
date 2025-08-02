using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Select an option (1-4): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by guiding you through a series of deep breathing exercises.");
            breathingActivity.DisplayStartingMessage();
            breathingActivity.Run();
            breathingActivity.DisplayEndingMessage();
        }

        else if (choice == "2")
        {
            ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
            reflectingActivity.DisplayStartingMessage();
            reflectingActivity.Run();
            reflectingActivity.DisplayEndingMessage();
        }

        else if (choice == "3")
        {
            ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            listingActivity.DisplayStartingMessage();
            listingActivity.Run();
            listingActivity.GetListFromUser();
            listingActivity.DisplayEndingMessage();
        }

        else if (choice == "4")
        {
            Console.WriteLine("Exiting the program. Goodbye!");
        }

        else
        {
            Console.WriteLine("Invalid choice. Please select a valid option.");
        }

    }
}

//I exceeded the requirements by adding functionality that saves user entries to separate txt files for both the ReflectingActivity and ListingActivity.