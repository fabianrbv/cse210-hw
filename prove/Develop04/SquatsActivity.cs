public class SquatsActivity : MindfulnessActivity
{
    public SquatsActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        DisplayStartingMessage("Squats Activity", "This activity focuses on mindful squat exercises.");

        Console.WriteLine($"Start mindful squat exercises for {duration} seconds...");
        ShowPause(duration);

        Console.WriteLine($"You've completed mindful squat exercises for {duration} seconds.");
        DisplayEndingMessage("Squats Activity", duration);
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
