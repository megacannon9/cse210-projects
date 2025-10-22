using System;

class Program23
{
    static void Main(string[] args)
    {
        //InClassPractice
        Word23 word1 = new Word23("Jesus");
        Word23 word2 = new Word23("wept.");
        word1.Display();
        word2.Display();
        word1.Hide();
        word1.Display();
        word2.Display();
    }
}