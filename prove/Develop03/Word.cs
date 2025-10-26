class Word
{
    //attributes
    private string _word;
    private bool _revealed;

    //behaviours
    public Word(string w) //constructors
    {
        _word = w;
        _revealed = true;
    }

    public void Display()
    {
        if (_revealed)
        {
            Console.Write(" " + _word);
        }
        else
        {
            Console.Write(" ___"); //change to match the length of the word somehow
        }
    }

    public void Hide() //setter
    {
        _revealed = false;
    }

    public bool GetRevealed() //getter
    {
        return _revealed;
    }

    public string DisplayWord()
    {
        return _word;
    }
    //AI wrote this override
    public override string ToString()
    {
        return _word;
    }
}