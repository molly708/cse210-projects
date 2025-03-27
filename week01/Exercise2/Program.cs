using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");


        string UserInput = Console.ReadLine();

        int grade = int.Parse(UserInput);
        string letter = "";


        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");


        if (grade >= 70)
        {
            Console.Write("You passed");            
        }

        else
        {
            Console.Write("You Failed.");
        }

        int last_digit = grade % 10;
        string sign = "";
 

        if (last_digit >= 7)
        {
            sign = "+";
        }

        else if (last_digit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        
        else if (letter == "F")
        {
            sign = "";
        }
        
        Console.WriteLine($"Your final grade is: {letter}{sign}");
    }
}