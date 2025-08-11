using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

public class ReflectingActivity : Activity
{
    private List<string> _prompt = new List<string>();
    private List<string> _questions = new List<string>();

    private List<string> _answers = new List<string>();

    public ReflectingActivity(string name, string description)
        : base(name, description)
    {
        name = "Reflecting Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompt.Add("Think of a time when you did something really difficult.");
        _prompt.Add("Think of a time when you stood up for someone else.");
        _prompt.Add("Think of a time when you did something really difficult.");
        _prompt.Add("Think of a time when you helped someone in need.");
        _prompt.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowCountdown(3);
        
        DisplayPrompt();
        DisplayQuestion();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            System.Threading.Thread.Sleep(3000); // Wait for 3 seconds before prompting again
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider this prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        Console.WriteLine("Now ponder on this related question:");
        Console.WriteLine(GetRandomQuestion());
        Console.WriteLine();
        Console.WriteLine("Start typing.");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">> ");
            _answers.Add(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter("ReflectingActivityAnswers.txt", true))
            {
                foreach (string answer in _answers)
                {
                    writer.WriteLine(answer);
                }
            }
        }
    }

}
