using System;

class Program
{
    static void Main(string[] args)
    {
        // welcome message
        DisplayWelcome();

        // This session request user's name and favorite number
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        // This section Calculate the square of the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // This section outputs the final  result
        DisplayResult(userName, squaredNumber);
    }

    //  welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Request  and returns the user's name as a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // request for and returns the user's favorite number as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Takes an integer parameter and returns its square
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // takes the user's name and squared number and displays them
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}

