public class EternalGoal : Goal
{
    public EternalGoal(string title, string description) : base(title, description) {}
    public EternalGoal() : base() {}
    public override void CreateGoal()
    {
        base.CreateGoal();
    }
    public override string GetSaveString()
    {
        return $"[ ] Eternal Goal: {_title} ({_desc}) -- Points: {_score}";
    }
    public override void LoadFromFile(string line)
    {
        int descStartIndex = line.IndexOf("(");
        int descEndIndex = line.IndexOf(")");
        int scoreStartIndex = line.IndexOf(" Points: ") + 9;
        _title = line.Substring(18, descStartIndex - 19);
        _desc = line.Substring(descStartIndex + 1, descEndIndex - descStartIndex - 1);
        _score = int.Parse(line.Substring(scoreStartIndex));

    }
}