// Clase para la actividad de Enumeración
public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        // Add more prompts as needed
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        DisplayStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random rand = new Random();
        string randomPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(randomPrompt);
        ShowPause(5);

        Console.WriteLine("Start listing items...");
        ShowPause(duration);

        Console.WriteLine($"You listed {duration} items.");
        DisplayEndingMessage("Listing Activity", duration);
    }

    public override void DisplayStartingMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}: {description}");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        ShowPause(3);
    }

    public override void DisplayEndingMessage(string activityName, int elapsedTime)
    {
        Console.WriteLine($"Good job! You have completed the {activityName} for {elapsedTime} seconds.");
        ShowPause(3);
    }
}