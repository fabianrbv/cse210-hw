using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, What is your grade percentage?");
        string answer = Console.ReadLine();
        int porcentage = int.Parse(answer);

        string letter = "";

        if (porcentage >= 90)
        {
            letter = "A";
        }

        else if (porcentage >= 80)
        {
            letter = "B";
        }
        else if (porcentage >= 70)
        {
            letter = "C";
        }
        else if (porcentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (porcentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}