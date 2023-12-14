public abstract class Goal
{
    protected string title;
    protected string description;
    protected bool isCompleted;
    protected int points;

    public Goal(string title, string description, int points)
    {
        this.title = title;
        this.description = description;
        this.points = points;
        isCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract void DisplayGoalStatus();

    public string GetTitle() => title;
    public string GetDescription() => description;
    public int GetPoints() => points;
}
