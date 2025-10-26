class Scripture
{
    //Reference
    Reference scriptureRef = new Reference("John", 11, 35);

    //attributes

    private List<Word> _scriptureWords = new List<Word>();

    //behaviours
    //AI wrote this Scripture Constructor
    public Scripture()
    {
        string text = "Jesus wept";
        string[] words = text.Split(' ');

        foreach (string w in words)
        {
            _scriptureWords.Add(new Word(w));
        }
    }
    //Get Rendered Text
    public void DisplayScripture()
    {
        //string scrip = string.Join(" ", _scriptureWords);
        Console.Write($"{scriptureRef.DisplayReference()} \"");//\"" + scrip + "\"");
        bool first = true;
        foreach (Word word in _scriptureWords)
        {
            if (first)
            {
                Console.Write($"{word.DisplayWord()}");
                first = false;
            }
            else
            {
                Console.Write($" {word.DisplayWord()}");
            }
        }
        Console.WriteLine("\"");
    }

    //Hide Words

    //Is Completely Hidden

    //setter

    //getter
}