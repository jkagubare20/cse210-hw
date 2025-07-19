using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "Trust in the Lord with all your heart, and lean not on your own understanding; in all your ways acknowledge Him, and He shall direct your paths.");

        Reference reference2 = new Reference("John", 3, 16);
        Scripture scripture2 = new Scripture(reference2, "For God so loved the world that He gave His only begotten Son, that whoever believes in Him should not perish but have everlasting life.");

        Console.WriteLine("Choose a scripture to memorize:");
        Console.WriteLine("1. Proverbs 3:5-6");
        Console.WriteLine("2. John 3:16");
        Console.Write("Enter 1 or 2: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            scripture1.Display();
        }
        else if (choice == "2")
        {
            scripture2.Display();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting.");
            return;
        }

        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        string input = Console.ReadLine();
        while (input != "quit")
        {
            scripture1.HideRandomWord();
            Console.Clear();
            scripture1.Display();
            if (scripture1.isCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Exiting.");
                break;
            }
            scripture2.HideRandomWord();
            Console.Clear();
            scripture2.Display();
            if (scripture2.isCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Exiting.");
                break;
            }
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            input = Console.ReadLine();
        }

    }
}