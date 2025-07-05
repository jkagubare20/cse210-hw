using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        
        List<int> numbers = new List<int>();
        int input = int.Parse(Console.ReadLine());

        while (input != 0)
        {
            numbers.Add(input);
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());
        }

        Console.Write("The sum of the numbers is: ");
        int sum = numbers.Sum();
        Console.WriteLine(sum.ToString());

        Console.Write("The average of the numbers is: ");
        double average = numbers.Count > 0 ? numbers.Average() : 0.00;  
        Console.WriteLine(average.ToString());

        Console.Write("The largest number is: ");
        int largest = numbers.Count > 0 ? numbers.Max() : 0;
        Console.WriteLine(largest.ToString());

    }
}
