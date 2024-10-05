public class Word {
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplay()
    {
        if (_isHidden == true)
        {
            return new string('_', _text.Length);
        }
        else 
        {
            return _text;
        }
    }
}