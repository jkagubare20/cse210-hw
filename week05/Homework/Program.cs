using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John Doe", "C# Basics");

        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Jane Smith", "Algebra", "Section 5.2", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Alice Johnson", "Literature", "The Great Gatsby Analysis");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

        Console.WriteLine();
    }
}