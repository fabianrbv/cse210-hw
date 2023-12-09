public abstract class MindfulnessActivity
{
    protected int duration;

    public abstract void StartActivity();
    public abstract void DisplayStartingMessage(string activityName, string description);
    public abstract void DisplayEndingMessage(string activityName, int elapsedTime);

        public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    protected void ShowPause(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}