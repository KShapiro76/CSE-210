using System.Runtime.CompilerServices;
/*Define Journal Class
_Entries list of entries

AddEntry: Generates and stores an entry in _Entries list
Display: displays each entry one by one
SaveToFile:Combines all entries as strings into one string 
    and puts it in a file
LoadFromFile:Takes single string and separates it into 
    individual entries to put into the _Entries list
*/
public class Journal
{
    public List<Entry> _Entries = new List<Entry>();
    public void AddEntry(List<string> Prompts)
    {
        /*Output example:
        What was the best part of my day?
         ~ When I ate my donut!
        */
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
        /* Output example:
        Date: 10/13/26 ~ Prompt: What was the best part of my day?
         ~ When I ate my donut!

        Date: 10/13/26 ~ Prompt: What was the strongest emotion I felt today?
         ~ I felt very happy today!
         
        */
        foreach (Entry entry in _Entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string fileName)
    {
        string entriesString = _Entries[0].ToFileString();
        foreach (Entry entry in _Entries.Skip(1))
        {
            entriesString += "\n" + (entry.ToFileString());
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
            int lineLength = part.Length;
            string partLine = part.Remove(lineLength-1);
            Entry entry1 = new Entry();
            entry1.FromFileEntry(partLine);
            _Entries.Add(entry1);
        }
    }
}