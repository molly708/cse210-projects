// Activity.cs

using System;

public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public abstract void RunActivity();

    protected void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {name}.\n{description}");
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        DisplayAnimation(3);
    }

    protected void EndMessage()
    {
        Console.WriteLine($"\nWell done! You have completed the {name} for {duration} seconds.");
        DisplayAnimation(3);

        // Log the activity completion
        Logger.LogActivity(name, duration);
    }

    protected void DisplayAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
