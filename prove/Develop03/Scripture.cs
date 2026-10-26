using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Scripture
{
    private List<Word> _scripture = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        string[] words = scriptureText.Split();
        foreach (string word in words)
        {
            Word word1 = new Word(word);
            _scripture.Add(word1);
        }
    }
    public bool StatusAllHidden()//Checks if all non-numerical words are hidden or not. Any numbers are verse numbers and don't need to be hidden
    {
        foreach (Word word in _scripture)
        {
            if (!int.TryParse(word.GetWord(), out _) && !word.IsHidden())
            {
                return false;
            }
        }
        return true;
        
    }
    public void HideThree() // Selects up to three random words and hides them.
    {
        Random rand = new Random();
        for (int i=1; i<4; i++)
        {
            int randIndex = rand.Next(0, _scripture.Count());
            if (_scripture[randIndex].IsHidden() || int.TryParse(_scripture[randIndex].GetWord(), out _))
            {
                i--;
            }
            else
            {
                _scripture[randIndex].Hide();
            }
            if (StatusAllHidden())
            {
                break;
            }
        }
    }
    public void Display() //Formats the scripture for the console.
    {
        _reference.Display();
        foreach (Word word in _scripture)
        {
            if (int.TryParse(word.GetWord(), out _))
            {
                Console.Write("\n" +word.GetWord() + " ");
            }
            else
            {
                Console.Write(word.GetWord() + " ");
            }
        }

    }
}