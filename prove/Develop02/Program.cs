using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");

        int i=0;
        while(i==0){

            var random = new Random();
            var list = new List<string>{ 
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"};

            var prompts = new List<string> {};

            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you want to do? ");
            string input = Console.ReadLine();
            sbyte option = sbyte.Parse(input);

            if (option == 1) //Write
            {
                int index = random.Next(list.Count);
                Console.WriteLine(list[index]);
                string prompt = Console.ReadLine();
                prompts.Add(prompt);

            }

            if (option == 2) //Display
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                foreach (string line in System.IO.File.ReadLines(filename))
                {  
                    System.Console.WriteLine(line);  
                }  
            }

            if (option == 3) //Load
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                }
            }

            if (option == 4) //Save
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(prompts);
                }
            }

            if (option == 5) //Quit
            {
                Console.WriteLine("Thanks for using Journal Program, Bye!!");
                i = 1;
            }

            if (option >5 || option <1) //Correct Number
            {
                Console.WriteLine("\n Type a correct option");
            }
        }
    }
}