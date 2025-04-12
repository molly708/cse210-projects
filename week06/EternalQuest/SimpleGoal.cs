using System;

namespace EternalQuest
{
  public class SimpleGoal : Goal
  {
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
      _isComplete = true;
      Console.WriteLine($"Congratulations! You earned {_points} points.");
    }

    public override bool IsComplete()
    {
      return _isComplete;
    }

    public override string GetStatus()
    {
      string checkbox = _isComplete ? "[X]" : "[]";
      return $"{checkbox} {_goalName} ({_description})";
    }

    public override string GetStringRepresentation() => $"SimpleGoal|{_goalName}|{_description}|{_points}|{_isComplete}";
  }
}
