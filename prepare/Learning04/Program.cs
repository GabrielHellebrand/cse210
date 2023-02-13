using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        System.Console.WriteLine(a1.GetSummary());
        MathAssignment a2 = new MathAssignment ("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        System.Console.WriteLine(a2.GetSummary());
        System.Console.WriteLine(a2.GetHomework());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The causes of World War 2");
        System.Console.WriteLine(a3.GetSummary());
        System.Console.WriteLine(a3.GetWritingInfo());
    }
}