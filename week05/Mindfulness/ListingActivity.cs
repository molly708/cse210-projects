using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> usedPrompts = new List<string>();

    private Random random = new Random();

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void RunActivity()
    {
        StartMessage();

        // Ensure all prompts are used before repeating
        if (usedPrompts.Count == prompts.Count)
            usedPrompts.Clear();

        string prompt;
        do
        {
            prompt = prompts[random.Next(prompts.Count)];
        } while (usedPrompts.Contains(prompt));

        usedPrompts.Add(prompt);

        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("You may begin listing items when the countdown ends.");
        DisplayProgressBar(3); // Display progress bar for 3 seconds before listing items

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">> ");
            string input = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        
        EndMessage();
    }

    // Display progress bar
    private void DisplayProgressBar(int seconds)
    {
        Console.Write("Progress: ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("▓");
            Thread.Sleep(1000); // Wait for 1 second
        }
        Console.WriteLine();
    }
}
