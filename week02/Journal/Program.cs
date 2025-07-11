using System;
using System.IO;

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
                Console.WriteLine("Enter the file name to load:");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                journal.LoadFromFile(fileName);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter the file name:");
                string fileName = Console.ReadLine();
                if (string.IsNullOrEmpty(fileName))
                {
                    Console.WriteLine("File name cannot be empty.");
                }
                else
                {
                    journal.SaveToFile(fileName);
                }
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

       //I exceeded requirements by fixing the prompt generator to not repeat prompts and providing responses when user input has not been given.
        //I also added a check to ensure the file name is not empty when saving entries.
    }
}