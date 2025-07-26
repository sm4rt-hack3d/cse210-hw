// Fraction.cs
using System;

public class Fraction
{
    // Private attributes
    private int numerator;
    private int denominator;

    // Constructor: default (1/1)
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor: one parameter (numerator, denominator = 1)
    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    // Constructor: two parameters
    public Fraction(int top, int bottom)
    {
        numerator = top;
        SetDenominator(bottom); // Use setter to handle zero
    }

    // Getter and Setter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int value)
    {
        numerator = value;
    }

    // Getter and Setter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    public void SetDenominator(int value)
    {
        if (value != 0)
        {
            denominator = value;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero. Setting to 1.");
            denominator = 1;
        }
    }

    // Return fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Return decimal value (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // Using all 3 constructors
        Fraction fraction1 = new Fraction();         // 1/1
        Fraction fraction2 = new Fraction(5);        // 5/1
        Fraction fraction3 = new Fraction(3, 4);     // 3/4
        Fraction fraction4 = new Fraction(1, 3);     // 1/3

        // Displaying fractions and their decimal values
        Console.WriteLine("Fraction 1: " + fraction1.GetFractionString() + " = " + fraction1.GetDecimalValue());
        Console.WriteLine("Fraction 2: " + fraction2.GetFractionString() + " = " + fraction2.GetDecimalValue());
        Console.WriteLine("Fraction 3: " + fraction3.GetFractionString() + " = " + fraction3.GetDecimalValue());
        Console.WriteLine("Fraction 4: " + fraction4.GetFractionString() + " = " + fraction4.GetDecimalValue());

        // Test setters and getters
        fraction3.SetNumerator(6);
        fraction3.SetDenominator(7);

        Console.WriteLine("Updated Fraction 3: " + fraction3.GetFractionString());
        Console.WriteLine("Updated Decimal 3: " + fraction3.GetDecimalValue());
    }
}
