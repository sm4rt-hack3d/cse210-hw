using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // ---------- Collect numbers ----------
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        // ---------- Sum ----------
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");

        // ---------- Average ----------
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // ---------- Maximum ----------
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // ---------- Stretch: Smallest positive ----------
        int smallestPositive = int.MaxValue;
        foreach (int n in numbers)
        {
            if (n > 0 && n < smallestPositive)
            {
                smallestPositive = n;
            }
        }

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        // ---------- Stretch: Sorted list ----------
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
