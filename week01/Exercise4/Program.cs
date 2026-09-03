using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers (type 0 when finished):");

        // user input loop
        while (true)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                break;
            }

            numbers.Add(input);
        }

        if (numbers.Count > 0)
        {
            // calculate the sum of the numbers
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            // average of the numbers
            double average = (double)sum / numbers.Count;

            // This section seek the  biggest number in the list
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            // This is the results section
            Console.WriteLine($"\nThe sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
