using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mindfulness App");
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");

        int choice;
        do
        {
            Console.Write("Enter your choice (1-3): ");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3);

        int duration;
        do
        {
            Console.Write("Enter the duration in seconds: ");
        } while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0);

        MindfulnessActivity activity;
        switch (choice)
        {
            case 1:
                activity = new BreathingActivity(duration);
                break;
            case 2:
                activity = new ReflectionActivity(duration);
                break;
            case 3:
                activity = new ListingActivity(duration);
                break;
            default:
                throw new NotImplementedException();
        }

        activity.StartActivity();
    }
}
