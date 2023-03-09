using System;
using System.Collections.Generic;

class ChecklistGoal: Goal
{
    private string Name { get; set; }
    private int Points { get; set; }
    private bool IsCompleted { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }
}