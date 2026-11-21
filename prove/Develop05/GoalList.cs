public class GoalList
{
    private List<Goal> _goals;
    int _cumulativeScore;

    public GoalList()
    {
        _goals = new List<Goal>();
        _cumulativeScore = 0;
    }
    public void CreateGoal()
    {
        do
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.WriteLine("  4. Exit");
            Console.Write("Which type of Goal would you like to create? ");

            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    SimpleGoal goal1 = new SimpleGoal();
                    goal1.CreateGoal();
                    _goals.Add(goal1);
                    return;
                case "2":
                    EternalGoal goal2 = new EternalGoal();
                    goal2.CreateGoal();
                    _goals.Add(goal2);
                    return;
                case "3":
                    ChecklistGoal goal3 = new ChecklistGoal();
                    goal3.CreateGoal();
                    _goals.Add(goal3);
                    return;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid entry. Please try again.");
                    break;
                
            }
        } while (true);
    }
    public void DisplayList()
    {
        for (int i=0; i<_goals.Count(); i++)
        {
            Console.Write($"{i+1}. ");
            _goals[i].DisplayGoal();
            Console.WriteLine();
        }
    }
    public int GetCumulativeScore()
    {
        return _cumulativeScore;
    }
    public void SavetoFile()
    {
        string projectFolder = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../.."));
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(projectFolder, fileName);
        string fileText = $"Total Points: {_cumulativeScore}\n";
        foreach (Goal goal in _goals)
        {
            fileText += goal.GetSaveString();
            fileText += "\n";
        }
        File.WriteAllText(filePath, fileText);
    }
    public void LoadFromFile()
    {
        string projectFolder = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../.."));
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(projectFolder, fileName);
        string[] lines = File.ReadAllLines(filePath);
        _cumulativeScore = int.Parse(lines[0].Substring(14));
        _goals.Clear();
        for (int i=0; i<lines.Count(); i++)
        {
            if (lines[i].Contains("Simple Goal"))
            {
                SimpleGoal goal1 = new SimpleGoal();
                goal1.LoadFromFile(lines[i]);
                _goals.Add(goal1);
            }
            else if (lines[i].Contains("Eternal Goal"))
            {
                EternalGoal goal1 = new EternalGoal();
                goal1.LoadFromFile(lines[i]);
                _goals.Add(goal1);
            }
            else if (lines[i].Contains("Checklist Goal"))
            {
                ChecklistGoal goal1 = new ChecklistGoal();
                goal1.LoadFromFile(lines[i]);
                _goals.Add(goal1);
            }
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i=0; i<_goals.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetTitle()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int input = int.Parse(Console.ReadLine());
        _cumulativeScore += _goals[input - 1].Award();
        Console.WriteLine($"You now have {_cumulativeScore} points.\n");
    }
}