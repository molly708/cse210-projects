using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        // Create a scripture with reference and text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding.");

        // Loop until all words are hidden or user quits
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");
            
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit") 
            {
                break;
            }

            scripture.hideWords();

            if (scripture.isCompletelyHidden()) 
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nAll words are hidden! Memorization complete.");
                break;
            }
        }
    }
}
