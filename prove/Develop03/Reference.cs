using System.Security.Cryptography;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private string _otherVerses;
    public Reference(string book, int chapter, int startverse) // for any reference with only 1 verse.
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startverse;
    }
    public Reference(string book, int chapter, int startverse, string otherVerses) // For any reference with more than 1 verse. 2 Nephi 2: 25-26 would be called with Reference("2 Nephi", 2, 25, "-26")
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startverse;
        _otherVerses = otherVerses;
    }
    public void Display()// Reformats the reference as a string for the console.
    {
        Console.WriteLine($"{_book} {_chapter}: {_startVerse}{_otherVerses}");
    }
}