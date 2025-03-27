using System;
using System.Collections.Generic;

public class Resume
{
  public string _name = "";
  public List<Job> Jobs = new List<Job>();
  public void Display()
  {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine("Jobs:");
    foreach (Job job in Jobs)
    {
        job.Display();
    }
  }
}