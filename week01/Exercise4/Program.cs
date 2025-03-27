using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>(); // List to store user input
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to get numbers from the user
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) // Only add to the list if it's not 0
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Check if the list has numbers before processing
        if (numbers.Count > 0)
        {
            double average = 0;
            int largest = numbers[0]; // Assume first number is largest
            int smallestPositive = int.MaxValue; // Start with a very high number
            int sum = 0; // Store sum of numbers

            // Loop through numbers to find largest, sum, and smallest positive
            foreach (int num in numbers)
            {
                sum += num;
                if (num > largest) largest = num;
                if (num > 0 && num < smallestPositive) smallestPositive = num;
            }

            // Calculate average
            average = (double)sum / numbers.Count;

            // Sort numbers
            numbers.Sort();

            Console.WriteLine($"The average is: {average:F2}");
            Console.WriteLine($"The largest number is: {largest}");

            // Display the smallest positive number if one was found
            if (smallestPositive == int.MaxValue)
                Console.WriteLine("No positive numbers were entered.");
            else
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

    }
}