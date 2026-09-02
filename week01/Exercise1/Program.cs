using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your first name?.");
        string firstName = Console.ReadLine();
         Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName}.");
    }
}

    
