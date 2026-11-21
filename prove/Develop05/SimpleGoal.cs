using System.Runtime.CompilerServices;

public class SimpleGoal: Goal
{
    private bool _isCompleted;
    public SimpleGoal(string title, string description) : base(title, description)
    {
        _isCompleted = false;
    }
    public SimpleGoal() : base() {}
    public override void CreateGoal()
    {
        base.CreateGoal();
    }
    public override void DisplayGoal()
    {
        string check;
        if (_isCompleted)
        {
            check = "X";
        }
        else
        {
            check = " ";
        }

        Console.Write($"[{check}] {_title} ({_desc})");
    }
    public override int Award()
    {
        _isCompleted = true;
        return base.Award();
    }
    public override string GetSaveString()
    {
        string check;
        if (_isCompleted)
        {
            check = "X";
        }
        else
        {
            check = " ";
        }
        return $"[{check}] Simple Goal: {_title} ({_desc}) -- Points: {_score}";
    }
    public override void LoadFromFile(string line)
    {
        string completeIndex = line.Substring(1, 1);
        int descStartIndex = line.IndexOf("(");
        int descEndIndex = line.IndexOf(")");
        int scoreStartIndex = line.IndexOf(" Points: ") + 9;
        _title = line.Substring(17, descStartIndex - 18);
        _desc = line.Substring(descStartIndex + 1, descEndIndex - descStartIndex - 1);
        _score = int.Parse(line.Substring(scoreStartIndex));
        if (completeIndex == " ")
        {
            _isCompleted = false;
        }
        else
        {
            _isCompleted = true;
        }
        
    }
}