using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName(); // PromptUserName function to get user's name
        int favoriteNumber = PromptUserNumber(); // PromptUserNumber function to get user's favorite number
        
        int squaredNumber = SquareNumber(favoriteNumber); // SquareNumber function with favorite number as input
        
        DisplayResult(name, squaredNumber); // DisplayResult function with name and squared number as input
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"Hello {name}, your favorite number squared is {squared}.");
    }

}