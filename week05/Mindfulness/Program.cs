using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3);
        RunActivity();
        End();
    }

    protected int Duration => _duration;

    private void End()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        var spinnerChars = new[] { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected abstract void RunActivity();
}

class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
        }
    }
}

class ReflectionActivity : Activity
{
    private static readonly List<string> prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    protected override void RunActivity()
    {
        Random rand = new();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {prompts[rand.Next(prompts.Count)]} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.Write($"\n> {question} ");
            ShowSpinner(5);
        }
    }
}

class ListingActivity : Activity
{
    private static readonly List<string> prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void RunActivity()
    {
        Random rand = new();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompts[rand.Next(prompts.Count)]} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> items = new();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (activity == null)
            {
                if (choice == "4") break;
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
                continue;
            }

            activity.Start();
        }
    }
}
