class Program
{
    static List<Goal> goals = new List<Goal>();
    static int userScore = 0;

    static void Main(string[] args)
    {
        bool quit = false;
        do
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1 Create a new goal");
            Console.WriteLine("2 List Goals");
            Console.WriteLine("3 Save Goals");
            Console.WriteLine("4 Load Goals");
            Console.WriteLine("5 Record Event");
            Console.WriteLine("6 Quit");

            Console.WriteLine($"Your score: {userScore}");

            int choice;
            do
            {
                Console.Write("Enter your choice (1-6): ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6);

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (!quit);
    }

    static void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1 Simple Goal");
        Console.WriteLine("2 Eternal Goal");
        Console.WriteLine("3 Checklist Goal");

        int choice;
        do
        {
            Console.Write("Enter your choice (1-3): ");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3);

        Console.Write("Enter goal title: ");
        string title = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points) || points <= 0)
        {
            Console.WriteLine("Invalid points. Please enter a positive integer.");
            Console.Write("Enter points: ");
        }

        switch (choice)
        {
            case 1:
                goals.Add(new SimpleGoal(title, description, points));
                break;
            case 2:
                goals.Add(new EternalGoal(title, description, points));
                break;
            case 3:
                Console.Write("Enter total times to complete: ");
                int totalTimes;
                while (!int.TryParse(Console.ReadLine(), out totalTimes) || totalTimes <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    Console.Write("Enter total times to complete: ");
                }

                Console.Write("Enter bonus points: ");
                int bonusPoints;
                while (!int.TryParse(Console.ReadLine(), out bonusPoints) || bonusPoints <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    Console.Write("Enter bonus points: ");
                }

                goals.Add(new ChecklistGoal(title, description, points, totalTimes, bonusPoints));
                break;
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayGoalStatus();
        }
    }

        static void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (Goal goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.GetTitle()}|{goal.GetDescription()}|{goal.GetPoints()}");
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while saving goals: {e.Message}");
        }
    }

    static void LoadGoals()
    {
        try
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    string type = data[0];
                    string title = data[1];
                    string description = data[2];
                    int points = int.Parse(data[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            goals.Add(new SimpleGoal(title, description, points));
                            break;
                        case "EternalGoal":
                            goals.Add(new EternalGoal(title, description, points));
                            break;
                        case "ChecklistGoal":
                            int totalTimes = int.Parse(data[4]);
                            int bonusPoints = int.Parse(data[5]);
                            goals.Add(new ChecklistGoal(title, description, points, totalTimes, bonusPoints));
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while loading goals: {e.Message}");
        }
    }

        static void RecordEvent()
    {
        Console.WriteLine("Select a goal to mark as completed:");
        ListGoals();

        int choice;
        do
        {
            Console.Write("Enter goal number: ");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > goals.Count);

        goals[choice - 1].RecordEvent();
        userScore += goals[choice - 1].GetPoints();
    }
}