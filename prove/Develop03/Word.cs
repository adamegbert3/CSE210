public class Word {

private bool _isVisible = true;

private string _text;

public string GetWord()
    {
        string text = _text;
        if (!_isVisible)
        {
            int len = text.Length;
            text = new string('_', len);
        }
        return text;

    }


public Word(string text)
    {
        _text = text;
    }

public void HideWord()
    {
        _isVisible = false;
    }

public bool CheckIsVisible()
    {
        return _isVisible;
    }
    
}