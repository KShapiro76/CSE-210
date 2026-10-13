
using System.Security;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public void Display()
    {
        Console.WriteLine(_date + _prompt + _response);
    }
    public string ToFileString()
    {
        string entryString = "|" + _date + _prompt + _response;
        return entryString;
    }
    public void FromFileEntry(string entryString)
    {
        string[] parts = entryString.Split("~");
        // foreach (string part in parts)
        // {
        //     Console.WriteLine(part);
        // }
        _date = parts[0] + "~";
        _prompt = parts[1] + "~";

        // The user's response may include the symbol ~ so after the prompt the rest is the response.
        _response = parts[2];
        foreach (string part in parts.Skip(3))
        {
            if (part.Length > 0)
            {
            _response += "~" + part;
            }
        }
    }
}