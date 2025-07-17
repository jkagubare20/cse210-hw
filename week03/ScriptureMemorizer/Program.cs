using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart, and lean not on your own understanding; in all your ways acknowledge Him, and He shall direct your paths.");
        scripture.Display();
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        string input = Console.ReadLine();
        while (input != "quit")
        {
            scripture.HideRandomWord();
            Console.Clear();
            scripture.Display();
            if (scripture.isCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Exiting.");
                break;
            }
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            input = Console.ReadLine();
        }


    }
}