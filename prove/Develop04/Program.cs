using System;
using System.Threading;

Console.WriteLine("Welcome to Mindfulness App");
Console.WriteLine("Choose an activity:");
Console.WriteLine("1. Breathing Activity");
Console.WriteLine("2. Reflection Activity");
Console.WriteLine("3. Listing Activity");
Console.WriteLine("4. SquatsActivity");

int choice;
do
{
    Console.Write("Enter your choice (1-4): ");
} while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4);

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
    case 4:
        activity = new SquatsActivity(duration);
        break;
    default:
        throw new NotImplementedException();
}

activity.StartActivity();
