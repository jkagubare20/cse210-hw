using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

   public void AddEntry(Entry newEntry)
   {
        if (_entries == null)
        {
            _entries = new List<Entry>();
        }
        
        // Set the date and prompt text for the entry
        newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
        PromptGenerator promptGenerator = new PromptGenerator();
        newEntry._promptText = promptGenerator.GetRandomPrompt();

        // Get user input for the entry text
        Console.WriteLine(newEntry._promptText);
        newEntry._entryText = Console.ReadLine();

        // Add the entry to the list
        _entries.Add(newEntry);
   }

   public void DisplayAll()
   {
    
        if (_entries == null || _entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
        else
        {
            foreach (Entry newEntry in _entries)
            {
                newEntry.DisplayEntry();
                Console.WriteLine();
            }
        }
   }

   public void SaveToFile(string file)
   {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date:{entry._date}- Prompt:{entry._promptText}, {entry._entryText}.");
                writer.WriteLine(); 
            }
        }
        Console.WriteLine("Entries saved to file.");   
   }

    public void LoadFromFile(string file)
    {   
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(file);

        Console.WriteLine("File content:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}