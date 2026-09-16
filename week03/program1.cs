using System;

namespace FractionApp
{
    public class Fraction
    {
        // Private attributes for top and bottom numbers
        private int _top;
        private int _bottom;

        // Constructor 1: No parameters - initializes to 1/1
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // Constructor 2: One parameter (top) - initializes bottom to 1
        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        // Constructor 3: Two parameters (top and bottom)
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        // Getter and Setter for top
        public int GetTop()
        {
            return _top;
        }

        public void SetTop(int top)
        {
            _top = top;
        }

        // Getter and Setter for bottom
        public int GetBottom()
        {
            return _bottom;
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        // Returns the fraction as a string, e.g., "3/4"
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        // Returns the decimal value of the fraction, e.g., 0.75
        public double GetDecimalValue()
        {
            return (double)_top / _bottom;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Test Constructor 1: 1/1
            Fraction f1 = new Fraction();
            Console.WriteLine(f1.GetFractionString());
            Console.WriteLine(f1.GetDecimalValue());

            // Test Constructor 2: 5/1
            Fraction f2 = new Fraction(5);
            Console.WriteLine(f2.GetFractionString());
            Console.WriteLine(f2.GetDecimalValue());

            // Test Constructor 3: 3/4
            Fraction f3 = new Fraction(3, 4);
            Console.WriteLine(f3.GetFractionString());
            Console.WriteLine(f3.GetDecimalValue());

            // Test Constructor 3: 1/3
            Fraction f4 = new Fraction(1, 3);
            Console.WriteLine(f4.GetFractionString());
            Console.WriteLine(f4.GetDecimalValue());

            // Test getters and setters
            f3.SetTop(7);
            f3.SetBottom(8);
            Console.WriteLine(f3.GetFractionString());
            Console.WriteLine(f3.GetDecimalValue());
        }
    }
}