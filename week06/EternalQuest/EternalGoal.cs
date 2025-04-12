using System;

namespace EternalQuest
{
  public class EternalGoal : Goal
  {

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // Override or extend functionality if needed
    public override void RecordEvent()
    {
      Console.WriteLine($"You earned {_points} points for {_goalName}!");
    }

    public override string GetStatus()
    {
      return $"[∞] {_goalName} ({_description})";
    }
  }
}
