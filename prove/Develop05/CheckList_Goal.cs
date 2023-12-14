public class ChecklistGoal : Goal
{
    private int totalTimes;
    private int completedTimes;
    private int bonusPoints;

    public ChecklistGoal(string title, string description, int points, int totalTimes, int bonusPoints) : base(title, description, points)
    {
        this.totalTimes = totalTimes;
        this.bonusPoints = bonusPoints;
        completedTimes = 0;
    }

    public override void RecordEvent()
    {
        completedTimes++;
        if (completedTimes == totalTimes)
        {
            isCompleted = true;
            // Add bonus points to user's score
            // ...
        }
        else
        {
            // Add points to user's score
            // ...
        }
    }

    public override void DisplayGoalStatus()
    {
        Console.WriteLine($"[{completedTimes}/{totalTimes}] {title} ({description})");
    }
}