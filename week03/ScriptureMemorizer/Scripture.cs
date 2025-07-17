using System;
using System.Collections.Generic; 
using System.Linq;

public class Scripture
{
    private string _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference.ToString();
        _words = text.Split(' ').Select(word => new Word(word)).ToList(); // Convert text to a list of Word objects
    }

    public void HideRandomWord()
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count > 0)
        {
            var random = new Random();
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}: {string.Join(" ", _words.Select(w => w.GetDisplayText()))}");
    }

    public bool isCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}