using System;

namespace ExerciseTracking
{
  public abstract class Activity
  {
    private DateTime _date;
    private int _lengthMinutes;

    // Constructor
    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    // Getters
    public DateTime GetDate() => _date;
    public int GetMinutes() => _lengthMinutes;

    // Abstract methods to be overridden
    public abstract double GetDistance(); // km or miles
    public abstract double GetSpeed();    // kph or mph
    public abstract double GetPace();     // min per km or mile

    // Virtual method: Can be overridden, but provides default behavior
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Activity ({_lengthMinutes} min): " +
               $"Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace: {GetPace():0.0}";
    }
}
}

