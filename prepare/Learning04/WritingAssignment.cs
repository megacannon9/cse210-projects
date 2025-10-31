using System.Net.Security;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string tl, string n, string t) : base(n,t)
    {
        _title =  tl;
    }
    
    public string GetWriting()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}