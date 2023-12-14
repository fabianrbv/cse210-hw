public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) : base(title, description, points) { }

    public override void RecordEvent()
    {
        // ...
    }

    public override void DisplayGoalStatus()
    {
        Console.WriteLine($"[X] {title} ({description})");
    }
}