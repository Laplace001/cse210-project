// User interface and control program
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nPlease choose one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry
                    {
                        _date = date,
                        _promptText = prompt,
                        _entryText = response
                    };

                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}

// Represents a single journal entry.
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

    // Format for saving to file (one line per entry, fields separated by ~|~)
    public string ToFileString()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }

    // Build an Entry from a saved line.
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split(new[] { "~|~" }, StringSplitOptions.None);
        if (parts.Length < 3) return null;

        return new Entry
        {
            _date = parts[0],
            _promptText = parts[1],
            _entryText = parts[2]
        };
    }
}

// collection of journal entries section.
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File not found: {filename}");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            Entry entry = Entry.FromFileString(line);
            if (entry != null)
            {
                _entries.Add(entry);
            }
        }
        Console.WriteLine($"Journal loaded from {filename}");
    }
}

// This section provides random writing prompts.
public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?",
        "What am I grateful for today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}