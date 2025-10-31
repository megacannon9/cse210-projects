public class Assignment
{
    private string _studentName;

    private string _topic;

    public Assignment(string n, string t)
    {
        _studentName = n;
        _topic = t;
    }

    public string GetAssignment()
    {
        string header = _studentName + " - " + _topic;
        return header;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}