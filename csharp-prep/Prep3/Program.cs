using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string answer = Console.ReadLine();
        // int magic_number = int.Parse(answer);

        // Console.Write("What is your guess? ");
        // string answer_2 = Console.ReadLine();
        // int guess = int.Parse(answer_2);

        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);


        int guess = -1;

        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magic_number)
        {
            Console.WriteLine("Higher");
        }

            else if (guess > magic_number)
        {
            Console.WriteLine("Lower");
        }

            else
        {
            Console.WriteLine("You guessed it!");
        }
    
        }

        

    }
}