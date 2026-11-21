public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonusScore;
    public ChecklistGoal(string title, string description) : base(title, description)
    {
        _timesCompleted = 0;
        _timesToComplete = 0;
        _bonusScore = 0;
    }
    public ChecklistGoal() : base() {}
    public override void CreateGoal()
    {
        base.CreateGoal();
        _timesCompleted = 0;
        Console.Write("How many times does this goal need to be completed for a bonus? ");
        _timesToComplete = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusScore = int.Parse(Console.ReadLine());
        Console.WriteLine();

    }
    public override void DisplayGoal()
    {
        string check;
        if (_timesCompleted == _timesToComplete && _timesToComplete != 0)
        {
            check = "X";
        }
        else
        {
            check = " ";
        }
        Console.Write($"[{check}] {_title} ({_desc}) -- Completed {_timesCompleted}/{_timesToComplete}");
    }
    public override int Award()
    {
        int awardedScore = _score;
        _timesCompleted += 1;
        if (_timesCompleted == _timesToComplete && _timesToComplete != 0)
        {
            awardedScore += _bonusScore;
        }
        Console.WriteLine($"Congratulations! You have earned {awardedScore} points.");
        return awardedScore;
    }
    public override string GetSaveString()
    {
        string check;
        if (_timesCompleted == _timesToComplete && _timesToComplete != 0)
        {
            check = "X";
        }
        else
        {
            check = " ";
        }
        return $"[{check}] Checklist Goal: {_title} ({_desc}) -- Completed {_timesCompleted}/{_timesToComplete} -- Points: {_score} -- BonusPoints: {_bonusScore}";
    }
    public override void LoadFromFile(string line)
    {
        //Example:
        //[ ] Checklist Goal:Attend the temple (go to the temple dude) -- Completed 1/3 -- Points: 75 -- BonusPoints: 300
        int descStartIndex = line.IndexOf("(");
        int descEndIndex = line.IndexOf(")");
        int completeEndIndex = line.IndexOf(" Completed ") + 13;
        int slashIndex = line.IndexOf("/");
        int scoreStartIndex = line.IndexOf(" Points: ") + 9;
        int bonusStartIndex = line.IndexOf(" BonusPoints: ") + 14;
        _title = line.Substring(20, descStartIndex - 21);
        _desc = line.Substring(descStartIndex + 1, descEndIndex - descStartIndex - 1);
        _score = int.Parse(line.Substring(scoreStartIndex, bonusStartIndex - scoreStartIndex - 17));
        Console.WriteLine(line.Substring(completeEndIndex - 2, slashIndex - completeEndIndex + 2));
        _timesCompleted = int.Parse(line.Substring(completeEndIndex - 2, slashIndex - completeEndIndex + 2));
        _timesToComplete = int.Parse(line.Substring(slashIndex + 1, scoreStartIndex - slashIndex - 12));
        _bonusScore = int.Parse(line.Substring(bonusStartIndex));
    }
}