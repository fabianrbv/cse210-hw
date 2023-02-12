using System;

public class Program
{
    static void Main(string[] args)
    {
        int i=0;
        while(i==0){

            var random = new Random();

            Reference reference1 = new Reference();
            reference1._book ="John";
            reference1._chapter ="3";
            reference1._verse ="16";

            Scripture scripture1 = new Scripture();
            reference1.Display();
            scripture1.Display();

            // Random palabra = new Random();
            // string palabras = palabra.Next(scripture1);

            // int index = random.Next(list.Count);
            // Console.WriteLine(list[index]);
            // response1._question = list[index];

            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            string quit = Console.ReadLine();
            Console.Clear();

            if (quit == "quit") 
            {
                Console.WriteLine("Thanks for using Scripture Memorizer!!");
                i = 1;
            }
        }
    }
}