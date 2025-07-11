using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {

        Random random = new Random();
        if (_prompts == null || _prompts.Count == 0)
        {
            _prompts = new List<string> // 
            {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
            };
            _prompts = _prompts.OrderBy(x => random.Next()).ToList();
        }
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}