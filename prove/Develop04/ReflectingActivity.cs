public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        DisplayStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Random rand = new Random();
        for (int i = 0; i < duration; i += 10)
        {
            string randomPrompt = prompts[rand.Next(prompts.Length)];
            Console.WriteLine(randomPrompt);
            ShowPause(5);

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                ShowPause(5);
            }
        }

        DisplayEndingMessage("Reflection Activity", duration);
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