using System;

public class Entry
{
    public string _givenPrompt;

    public string _entryDateTime;

    public string _entryText;

    public void DisplayEntries()
    {
        Console.WriteLine($"{_entryText}");
    }
}

