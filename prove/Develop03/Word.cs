public class Word
{
    private string _word;
    private bool _isHidden;
    public Word()
    {
        _word = "";
        _isHidden = false;
    }
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public void Hide() //if Switches whether it's hidden or not.
    {
        if (_isHidden)
        {
            _isHidden = false;
        }
        else
        {
            _isHidden = true;
        }
    }
    public bool IsHidden() // Checks if the word is hidden or not.
    {
        return _isHidden;
    }
    public string GetWord() // returns the word as a string, and as "_" x length if hidden
    {
        string wordForm;
        if (_isHidden)
        {
            wordForm = new string('_', _word.Length);
        }
        else
        {
            wordForm = _word;
        }
        return wordForm;
    }
}