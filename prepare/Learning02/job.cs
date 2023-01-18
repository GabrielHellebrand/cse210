using System;
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public void display()
    {
        Console.WriteLine($"{_company}({_jobTitle}){_endYear}-{_startYear}");
    }

}