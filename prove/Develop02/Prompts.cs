using System;

public class Prompts
{
    public string _smell;

    public string _smile;

    public string _hard;

    public string _learn;

    public string _sight;

    public Random _randomProducer;
    
    public Prompts()
    {
        _randomProducer = new Random();
        _promptList = new List<string>();
    }
    public List<string> _promptList;

    public int _selectedPromptIndex;

    public string GeneratePrompt()
    {
        _selectedPromptIndex = _randomProducer.Next(_promptList.Count); // Random index
        return _promptList[_selectedPromptIndex];
    }
}