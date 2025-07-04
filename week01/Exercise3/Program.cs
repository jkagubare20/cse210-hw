using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100); // Generates a number between
        Console.WriteLine("Guess the magic number? ");

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }
        
        if (guess == magicNumber)
        {
            Console.WriteLine($"Congratulations! {guess} is the magic number!");
        }
    }
}