using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (scripture.HasHiddenWords())
        {
            DisplayScripture(scripture);
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords();
            Console.Clear();
        }

        Console.WriteLine("All words in the scripture are hidden. Press any key to exit.");
        Console.ReadKey();
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine("");
        Console.WriteLine($"Scripture Reference: {scripture.GetReference()}");
        Console.WriteLine(scripture.GetDisplayText());
    }
}