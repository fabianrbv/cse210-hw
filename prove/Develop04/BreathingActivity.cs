// Clase para la actividad de Respiración
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        DisplayStartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        for (int i = 0; i < duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            ShowPause(2);
            Console.WriteLine("Breathe out...");
            ShowPause(2);
        }
        DisplayEndingMessage("Breathing Activity", duration);
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