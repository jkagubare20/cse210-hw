using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry entry = new Entry();
                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();

            }
            else if (choice == 3)
            {
                Console.WriteLine("You chose to load.");
                // Here you would typically call a method to handle loading entries from a file
            }
            else if (choice == 4)
            {
                Console.WriteLine("You chose to save.");
                // Here you would typically call a method to handle saving entries to a file
            }
            else if (choice == 5)
            {
                Console.WriteLine("You chose to quit. Goodbye!");
                return; // Exit the program
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }


    }
}