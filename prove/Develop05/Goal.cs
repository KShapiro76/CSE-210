using System.Globalization;
using System.Numerics;
using System.Security;

public abstract class Goal
{
    protected string _title;
    protected string _desc;
    protected int _score;
    public Goal(string title, string description)
    {
        _title = title;
        _desc = description;
        _score  = 0;
    }
    public Goal() {}
    public string GetTitle()
    {
        return _title;
    }
    public virtual int Award()
    {
        Console.WriteLine($"Congratulations! You have earned {_score} points.");
        return _score;
    }
    public virtual void CreateGoal() 
    {
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is a short description of it? ");
        _desc = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _score = int.Parse(Console.ReadLine());
    }
    public virtual void DisplayGoal()
    {
        Console.Write($"[ ] {_title} ({_desc})");
    }
    public abstract string GetSaveString();
    public virtual void LoadFromFile(string line)
    {
        
    }
    
}