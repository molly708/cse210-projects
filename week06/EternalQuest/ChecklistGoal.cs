using System;

namespace EternalQuest
{
  public class ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : Goal(name, description, points)
  {
    private int _targetCount = targetCount;

    private int _currentCount = 0;
    private int _bonusPoints = bonusPoints;

    public override void RecordEvent()
    {
      if (_currentCount < _targetCount)
      {
        _currentCount++;
        Console.WriteLine($"Progress made! Current task completion: {_currentCount}/{_targetCount}");
                
        if (_currentCount == _targetCount)
        {
          Console.WriteLine($"Congratulations! You've completed the checklist and earned an additional {_bonusPoints} points.");
          _points += _bonusPoints; // Add bonus points when goal is complete
        }
      }
      else
      {
        Console.WriteLine("All tasks are already completed.");
      }
    }
    

    public int GetBonus()
    {
      return _bonusPoints;
    }

    // Override IsComplete: Check if current progress matches the target count
    public override bool IsComplete()
    {
      return _currentCount == _targetCount;
    }

    // Override GetStatus: Show progress of tasks completed vs. total tasks
    public override string GetStatus()
    {
      return $"{_goalName}: {_currentCount}/{_targetCount} tasks completed. {_description}";
    }

    // Override GetStringRepresentation: Format the goal details for saving/loading
    public override string GetStringRepresentation()
    {
      return $"ChecklistGoal|{_goalName}|{_description}|{_points}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }

    public int GetCompletions()
    {
      return _currentCount;
    }

    public void SetCurrentCount(int count)
    {
        _currentCount = count;
    }
  }
}