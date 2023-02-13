using System;
public class Assignment
{
    private string _studentName;
    private string _subject;
    public Assignment(string studentName, string subject)
    {
        _studentName = studentName;
        _subject = subject;
    }
    public string GetName()
    {
        return _studentName;
    }
    public string GetSubject()
    {
        return _subject;
    }
    public string GetSummary()
    {
        return _studentName + " _ " + _subject;
    }
}
