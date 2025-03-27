using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");
        string response = "yes";
        while (response.ToLower() == "yes")
        {
            Random randomGenerator = new Random();

            int answer = randomGenerator.Next(1, 101);

            
            int guess = 0;
            int guessCount = 0;


            while (guess != answer)
            {   
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;


                if (guess > answer)
                {
                    Console.WriteLine("Lower.");
                }

                else if (guess < answer)
                {
                    Console.WriteLine("Higher.");
                }

            }

            Console.WriteLine($"Correct. You guessed the number in {guessCount} tries.");


            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine();
        }
        Console.WriteLine("Goodbye!");
    }
}