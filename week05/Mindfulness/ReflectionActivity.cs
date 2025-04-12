using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
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

    private Random random = new Random();

    public ReflectionActivity() : base("Reflection Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public override void RunActivity()
    {
        StartMessage();
        DateTime startTime = DateTime.Now;
        int elapsed = 0;

        // Display a random prompt
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        DisplayProgressBar(3); // Giving the user some time to think about the prompt

        while (elapsed < duration)
        {
            // Display a random question
            string question = questions[random.Next(questions.Count)];
            Console.WriteLine($"\nQuestion: {question}");
            DisplayProgressBar(5); // Give user time to think

            // Update the elapsed time
            elapsed = (int)(DateTime.Now - startTime).TotalSeconds;
        }

        EndMessage();
        
        // Log the activity completion with details
        Logger.LogActivity(name, duration, $"Prompt: {prompt}");
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
