using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // Prompt for first name
        Console.WriteLine("Enter your first name: ");
        string firstName = Console.ReadLine();

        // Prompt for last name
        Console.WriteLine("Enter your last name: ");
        string lastName = Console.ReadLine();

        // Display the result in “Bond, James Bond” style
        Console.WriteLine($"Your name is {lastName}, {firstName}, {lastName}");
    }
}