public class ScriptureBank
{
    private List<Scripture> _scriptures;
    public ScriptureBank() // Default constructor adds 3 scriptures to it automatically
    {
        _scriptures = new List<Scripture>();
        
        Scripture Nephi2 = new Scripture(new Reference("2 Nephi", 2, 25), "25 Adam fell that men might be; and men are, that they might have joy.");

        Scripture Alma37 = new Scripture(new Reference("Alma", 37, 6, "-7"), "6 Now ye may suppose that this is foolishness in me; but behold, I will show unto you that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. 7 And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls.");
        
        Scripture Moroni10 = new Scripture(new Reference("Moroni", 10, 4, "-5"), "4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. 5 And by the power of the Holy Ghost ye may know the truth of all things.");

        AddScripture(Nephi2);
        AddScripture(Alma37);
        AddScripture(Moroni10);
    }
    private void AddScripture(Scripture scripture) // Adds a scripture to the list
    {
        _scriptures.Add(scripture);
    }
    public Scripture GetRandomScripture() // Gets a random Scripture from the list
    {
        Random rand = new Random();
        int randIndex = rand.Next(0, _scriptures.Count());
        return _scriptures[randIndex];
    }
}