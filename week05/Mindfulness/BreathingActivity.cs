// BreathingActivity.cs

using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void RunActivity()
    {
        StartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            AnimateBreathing("Breathe in...", true);
            AnimateBreathing("Breathe out...", false);
        }

        EndMessage();
    }

    private void AnimateBreathing(string message, bool expand)
    {
        int steps = 20; // Number of animation steps
        int delay = 100; // Delay in milliseconds between steps

        Console.Clear();
        Console.WriteLine(message);

        for (int i = 1; i <= steps; i++)
        {
            int size = expand ? i : (steps - i + 1);
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(new string('*', size));
            Thread.Sleep(delay);
        }

        DisplayAnimation(2); // Pauses for 2 seconds before switching phases
    }
}
