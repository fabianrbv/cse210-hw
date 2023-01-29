using System;
using System.IO; 

public class Entry 
{
    public string _question;
    public string _response;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"{_question}, {_response}, {_date}");
    }
}

public class Journal
{
    // public string _name;
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        // Console.WriteLine($"Name: {_name}");
        // Console.WriteLine("entry:");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");

        int i=0;
        while(i==0){

            var random = new Random();
            var list = new List<string>{ 
                "What goal did I miss?",
                "what would have done better?",
                "what was your favorite thing today?",
                "What did you learn from your scriptures study?",
                "What new thought do I have for tomorrow?"};

            var prompts = new List<string> ();

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
                Entry response1 = new Entry();
                
                int index = random.Next(list.Count);
                Console.WriteLine(list[index]);
                response1._question = list[index];

                response1._response = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                response1._date = theCurrentTime.ToShortDateString();

                Journal j = new Journal();

                j._entries.Add(response1);
                j.Display();

            }

            if (option == 2) //Display
            {

                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            if (option == 3) //Load
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);


            }

            if (option == 4) //Save
            {

                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();


                Entry _entries = new Entry();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(_entries);
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