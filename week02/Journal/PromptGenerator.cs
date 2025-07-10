using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {

        Random random = new Random();
        // Initialize prompts if not already done
        if (_prompts == null || _prompts.Count == 0)
        {
            _prompts = new List<string> // 
            {
            "What was the best part of your day?",
            "Who did you help today?",
            "What are you grateful for?",
            "Describe a challenge you faced today.",
            "What made you smile today?"
            };
        }
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}