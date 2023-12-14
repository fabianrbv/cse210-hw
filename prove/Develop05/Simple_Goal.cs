public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points) : base(title, description, points) { }

    public override void RecordEvent()
    {
        isCompleted = true;
    }

    public override void DisplayGoalStatus()
    {
        Console.WriteLine($"[{(isCompleted ? "X" : " ")}] {title} ({description})");
    }
}