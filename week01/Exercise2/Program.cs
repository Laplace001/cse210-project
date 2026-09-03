using System;

class Program
{
    static void Main(string[] args)
    {
        // request grade from user in percentage
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        //  store the letter grade with a variable
        string letter = "";

        // assigns grade letter using the controls if, else if, else
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // prints the letter grade
        Console.WriteLine($"Your grade is: {letter}");
        
        // determine if the user passed or failed  the course
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! Good work!");
        }
        else
        {
            Console.WriteLine("no room for worries! Work on your low end and you will be shocked at the result!");
        }
    }
}

