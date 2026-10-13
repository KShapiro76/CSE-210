using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _Entries = new List<Entry>();
    public void AddEntry(List<string> Prompts)
    {
        Entry entry1 = new Entry();
        Random rand = new Random();
        int randomPrompt = rand.Next(Prompts.Count());

        entry1._prompt = Prompts[randomPrompt];
        Console.WriteLine(entry1._prompt);
        entry1._prompt = $"Prompt: {entry1._prompt}\n ~ ";
        Console.Write(" ~ ");
        entry1._response = Console.ReadLine();
        DateTime dateTime = DateTime.Now;
        entry1._date = $"Date: {dateTime.ToString("MM/dd/yy")} ~ ";
        _Entries.Add(entry1);
    }
    public void Display()
    {
        foreach (Entry entry in _Entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string fileName)
    {
        string entriesString = "";
        foreach (Entry entry in _Entries)
        {
            entriesString += (entry.ToFileString());
        }
        File.WriteAllText(fileName, entriesString);
    }
    public void LoadFromFile(string fileName)
    {
        _Entries.Clear();
        string fileLines = System.IO.File.ReadAllText(fileName);
        List<string> parts = new List<string>();
        string[] fileLineParts = fileLines.Split("|");
        foreach (string line in fileLineParts)
        {
            parts.Add(line);
        }
        parts.RemoveAt(0);
        
        foreach (string part in parts)
        {
            Entry entry1 = new Entry();
            entry1.FromFileEntry(part);
            _Entries.Add(entry1);
        }
    }
}