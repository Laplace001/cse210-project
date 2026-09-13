// storage program
using System;
using System.Collections.Generic;
using System.IO;
// member variables
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
            Console.WriteLine("\nNo entries to display.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // Escape pipe characters in user text to preserve formatting on load
                string safePrompt = entry._promptText.Replace("|", "~|~");
                string safeResponse = entry._entryText.Replace("|", "~|~");
                outputFile.WriteLine($"{entry._date}|~|{safePrompt}|~|{safeResponse}");
            }
        }
        Console.WriteLine($"Journal saved successfully to {file}.");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "|~|" }, StringSplitOptions.None);
            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1].Replace("~|~", "|"),
                    _entryText = parts[2].Replace("~|~", "|")
                };
                _entries.Add(entry);
            }
        }
        Console.WriteLine($"Journal loaded successfully from {file}.");
    }
}