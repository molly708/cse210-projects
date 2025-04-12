using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
  public class GoalManager
  {
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
      string input = "";
      while (input != "6")
      {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        input = Console.ReadLine();

        switch (input)
        {
          case "1": CreateGoal(); break;
          case "2": ListGoalDetails(); break;
          case "3": SaveGoals(); break;
          case "4": LoadGoals(); break;
          case "5": RecordEvent(); break;
        }
      }
    }

    public void CreateGoal()
    {
      Console.WriteLine("The types of Goals are:");
      Console.WriteLine("1. Simple Goal");
      Console.WriteLine("2. Eternal Goal");
      Console.WriteLine("3. Checklist Goal");
      Console.Write("Which type of goal would you like to create? ");
      string choice = Console.ReadLine();

      Console.Write("Enter goal name: ");
      string name = Console.ReadLine();
      Console.Write("Enter description: ");
      string desc = Console.ReadLine();
      Console.Write("Enter points: ");
      int points = int.Parse(Console.ReadLine());

      if (choice == "1")
      {
        _goals.Add(new SimpleGoal(name, desc, points));
      }
      else if (choice == "2")
      {
        _goals.Add(new EternalGoal(name, desc, points));
      }
      else if (choice == "3")
      {
        Console.Write("Enter target completions: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus: ");
        int bonus = int.Parse(Console.ReadLine());
        _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
      }
    }

    public void ListGoalDetails()
    {
      for (int i = 0; i < _goals.Count; i++)
      {
        Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
      }
    }

    public void RecordEvent()
    {
      if (_goals.Count == 0)
      {
        Console.WriteLine("No goals to record yet.");
        return;
      }

      Console.WriteLine("Which goal did you accomplish?");
      ListGoalDetails();

      Console.Write("Enter the number of the completed goal: ");
      if (int.TryParse(Console.ReadLine(), out int choice))
      {
        int index = choice - 1;

        if (index >= 0 && index < _goals.Count)
        {
          Goal goal = _goals[index];
          goal.RecordEvent();
          _score += goal.GetPoints();

          if (goal is ChecklistGoal cg && cg.IsComplete())
          {
            _score += cg.GetBonus();
          }

          Console.WriteLine("Event recorded!");
        }
        else
        {
          Console.WriteLine("Invalid goal number.");
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter a valid number.");
      }
    }

    public void SaveGoals()
    {
      Console.Write("Enter filename: ");
      string filename = Console.ReadLine();
      if (!filename.EndsWith(".txt"))
      {
        filename += ".txt";
      }

      using (StreamWriter writer = new StreamWriter(filename))
      {
        writer.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
          writer.WriteLine(goal.GetStringRepresentation());
        }
      }
    }

    public void LoadGoals()
    {
      Console.Write("Enter filename: ");
      string filename = Console.ReadLine();
      if (!filename.EndsWith(".txt"))
      {
        filename += ".txt";
      }

      if (!File.Exists(filename))
      {
        Console.WriteLine("File not found.");
        return;
      }

      string[] lines = File.ReadAllLines(filename);
      _score = int.Parse(lines[0]);
      _goals.Clear();

      for (int i = 1; i < lines.Length; i++)
      {
        string[] parts = lines[i].Split('|');
        string type = parts[0];

        if (type == "SimpleGoal")
        {
          _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
        }
        else if (type == "EternalGoal")
        {
          _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
        }
        else if (type == "ChecklistGoal")
        {
          var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
          int completions = int.Parse(parts[6]);
          goal.SetCurrentCount(completions);
          _goals.Add(goal);
        }
      }
    }
  }
}
