class Reference
{
    //Book, Chapter, and verse information


    //attributes
    //private List<string> _refer = new List<string> { "John 11:35", };
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    //behaviours
    public string DisplayReference()
    {
        //probably need a way to factor in whether or not there is an endverse
        string fullReference = "";
        if (_endVerse == 0)
        {
            fullReference = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            fullReference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return fullReference;
    }

    public Reference(string b, int c, int s, int e = 0)
    {
        if (e == 0)
        {
            SingleVerse(b, c, s);
        }
        else
        {
            MultiVerse(b, c, s, e);
        }
    }

    private void SingleVerse(string b, int c, int s)
    {
        _book = b;
        _chapter = c;
        _startVerse = s;
    }

    private void MultiVerse(string b, int c, int s, int e)
    {
        _book = b;
        _chapter = c;
        _startVerse = s;
        _endVerse = e;
    }
    //setter

    //getter
}