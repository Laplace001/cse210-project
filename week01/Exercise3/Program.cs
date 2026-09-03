using System;

class Program
{
    static void Main(string[] args)
    {
        // This section generates a random number from 1 to 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = -1;

        // loop runs until the the appropriate magic number is guessed rightly
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}

