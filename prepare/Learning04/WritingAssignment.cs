using System;
public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string subject, string title)
        : base(studentName, subject)
        {
            _title = title;
        }
        public string GetWritingInfo()
        {
            string studentName = GetName();
            return $"{_title} by {studentName}";
        }
}