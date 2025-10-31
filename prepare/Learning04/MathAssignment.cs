using System.Security.Cryptography;

public class MathAssignment : Assignment
{
    private string _textbookSection;

    private string _problems;

    public MathAssignment(string tbs, string p, string n, string t) : base(n, t)
    {
        _textbookSection = tbs;
        _problems = p;
    }
    
    public string GetMath()
    {
        return $"Section {_textbookSection} Problems {_problems}";
;
    }
}