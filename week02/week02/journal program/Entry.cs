//individual journal entry program
using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
// member variables
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
//Encapsulates how a single entry prints itself to the console in a clear format
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }
}