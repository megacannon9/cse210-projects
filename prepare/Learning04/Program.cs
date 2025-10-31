using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Micler", "math");
        MathAssignment testMath = new MathAssignment("7", "8-19", "Samuel", "Division");
        WritingAssignment testWriting = new WritingAssignment("Best of JRA", "Takahashi", "English");

        Console.WriteLine(test.GetAssignment());
        Console.WriteLine();
        Console.WriteLine(testMath.GetAssignment());
        Console.WriteLine(testMath.GetMath());
        Console.WriteLine();
        Console.WriteLine(testWriting.GetAssignment());
        Console.WriteLine(testWriting.GetWriting());
    }
} 