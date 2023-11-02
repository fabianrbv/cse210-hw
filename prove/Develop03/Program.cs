// using System;

// public class Program
// {
//     static void Main(string[] args)
//     {
//         int i=0;
//         while(i==0){

//             var random = new Random();

//             Reference reference1 = new Reference();
//             reference1._book ="John";
//             reference1._chapter ="3";
//             reference1._verse ="16";

//             Scripture scripture1 = new Scripture();
//             reference1.Display();
//             scripture1.Display();

//             // Random palabra = new Random();
//             // string palabras = palabra.Next(scripture1);

//             // int index = random.Next(list.Count);
//             // Console.WriteLine(list[index]);
//             // response1._question = list[index];

//             Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
//             string quit = Console.ReadLine();
//             Console.Clear();

//             if (quit == "quit") 
//             {
//                 Console.WriteLine("Thanks for using Scripture Memorizer!!");
//                 i = 1;
//             }
//         }
//     }
// }

using System;

 

class Program
{
    static void Main()
    {
        string scriptureReference = "John 3:16";
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

 

        Console.Clear();
        DisplayScripture(scriptureReference, scriptureText);

 

        while (true)
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().ToLower();

 

            if (input == "quit")
            {
                break;
            }

 

            HideRandomWords(ref scriptureText);
            Console.Clear();
            DisplayScripture(scriptureReference, scriptureText);

 

            if (AllWordsHidden(scriptureText))
            {
                break;
            }
        }
    }

 

    static void DisplayScripture(string reference, string text)
    {
        Console.WriteLine("{0}\n\n{1}\n", reference, text);
    }

 

    static void HideRandomWords(ref string text)
    {
        string[] words = text.Split(' ');
        int numWordsToHide = Math.Min(3, words.Length); // hide up to 3 words

 

        for (int i = 0; i < numWordsToHide; i++)
        {
            int index = new Random().Next(words.Length);
            words[index] = "___";
        }

 

        text = string.Join(" ", words);
    }

 

    static bool AllWordsHidden(string text)
    {
        return !text.Contains(" ");
    }
}