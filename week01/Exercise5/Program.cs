using System;

class Program
{
    static void Main()
    {
        // Step 1: Display welcome message
        DisplayWelcome();

        // Step 2: Get user's name
        string userName = PromptUserName();

        // Step 3: Get user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Step 4: Square the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Step 5: Display the result
        DisplayResult(userName, squaredNumber);
    }

    // Function 1: Welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function 2: Prompt for user name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function 3: Prompt for favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function 4: Square the number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 5: Display the result
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}.");
    }
}
