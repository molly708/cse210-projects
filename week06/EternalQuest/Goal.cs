using System;

namespace EternalQuest
{
  public class Goal(string name, string description, int points)
  {
    protected string _goalName = name;
    protected string _description = description;
    protected int _points = points;

    public string GetGoalName()
    {
      return _goalName;
    }

    public void SetGoalName(string goalName)
    {
      _goalName = goalName;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string description)
    {
      _description = description;
    }

    public int GetPoints()
    {
      return _points;
    }

    public void SetPoints(int points)
    {
      _points = points;
    }

    public virtual void RecordEvent()
    {
    }

    public virtual bool IsComplete()
    {
      return false;
    }

    public virtual string GetStatus()
    {
      return "";
    }

    public virtual string GetDetailsString()
    {
      return GetStatus(); // You can customize how each goal displays
    }


    public virtual string GetStringRepresentation()
    {
      // Return a string representation for saving/loading
      return $"{_goalName}|{_description}|{_points}";
    }
  }
}