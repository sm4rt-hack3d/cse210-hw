using System;

class GradeCalculator
{
    static void Main()
    {
        // Prompt for the grade percentage
        Console.Write("Enter your grade percentage (whole number): ");
        string input = Console.ReadLine();

        // Parse the input as an integer
        int percentage = int.Parse(input);

        // Determine the letter grade
        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter grade
        Console.WriteLine($"\nYour letter grade is: {letter}");

        // Congratulate or encourage the student
        if (percentage >= 70)
        {
            Console.WriteLine("🎉 Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("💪 Keep working hard—you’ll do better next time!");
        }
    }
}
