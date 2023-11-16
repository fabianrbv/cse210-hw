using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Entry
{
    public string Question { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {Question}");
        Console.WriteLine(Response);

    }
}

public class Journal
{
    public List<Entry> Entries { get; set; }
    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void Display()
    {
        foreach (var entry in Entries)
        {
            entry.Display();
        }
    }
}

public class Program
{
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");

        int i = 0;
        while (i == 0)
        {
            var random = new Random();
            var list = new List<string>{ 
                "What goal did I miss?",
                "what would have done better?",
                "what was your favorite thing today?",
                "What did you learn from your scriptures study?",
                "What new thought do I have for tomorrow?"};
                
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit ");
            Console.Write("What do you want to do? ");
            string input = Console.ReadLine();
            int option = int.Parse(input);

            if (option == 1) //Write
            {   
                Entry response1 = new Entry();
                
                int index = random.Next(0, list.Count);
                string randomItem = list[index];

                Console.WriteLine(randomItem);
                response1.Question = randomItem;

                response1.Response = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                response1.Date = theCurrentTime.ToShortDateString();

                journal.Entries.Add(response1);
            }

            if (option == 2) //Display
            {
                journal.Display();
            }

            if (option == 3) //Load
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] entryParts = line.Split(',');
                    Entry entry = new Entry
                    {
                        Date = entryParts[0].Trim(),
                        Question = entryParts[1].Trim(),
                        Response = entryParts[2].Trim()
                    };
                    journal.Entries.Add(entry);
                }
            }

            if (option == 4) //Save
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (var entry in journal.Entries)
                    {
                        outputFile.WriteLine($"{entry.Date}, {entry.Question}, {entry.Response}");
                    }
                }
            }

            if (option == 5) //Quit
            {
                Console.WriteLine("Thanks for using Journal Program, Bye!!");
                i = 1;
            }

            if (option > 5 || option < 1) //Correct Number
            {
                Console.WriteLine("\n Type a correct option");
            }
        }
    }
}