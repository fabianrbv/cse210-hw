using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        Scripture proverbsScripture = new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        Scripture johnScripture = new Scripture("John 3:5", "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");

        Scripture currentScripture = proverbsScripture;

        while (currentScripture.HasHiddenWords())
        {
            DisplayScripture(currentScripture);
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            currentScripture.HideRandomWords();
            Console.Clear();

            if (!currentScripture.HasHiddenWords() && currentScripture == proverbsScripture)
            {
                Console.WriteLine("Congratulations! You have memorized the first scripture.");
                Console.WriteLine("Ready for level 2?");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                currentScripture = johnScripture;
            }
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