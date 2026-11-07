public class Prompt
{
    private string _text;
    private bool _Selected;
    public Prompt(string text)
    {
        _text = text;
        _Selected = false;
    }
    public void SelectOrDeselect()
    {
        if (_Selected)
        {
            _Selected = false;
        }
        else
        {
            _Selected = true;
        }
    }
    public string GetText()
    {
        return _text;
    }
    public bool IsSelected()
    {
        return _Selected;
    }
}