using System;

class Program
{
    static void Main(string[] args)
    {
        bool ProgramFinish = false;
        Console.Clear();
        Scripture ProgramScripture = new Scripture();
        ProgramScripture.DisplayScripture();
        Console.WriteLine("Press ENTER to continue or QUIT to end.");
        while (ProgramFinish == false)
        {
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                Console.Clear();
                ProgramFinish = true;
            }
            else
            {
                Console.Clear();
                ProgramScripture.DisplayScripture();
                ProgramScripture.HideScripture();
                Console.ReadLine();
            }
        }
    }
}