using System;
using System.Collections.Generic;
class SimpleGoal: Goal
{
    private string Name { get; set; }
    private int Points { get; set; }
    private bool IsCompleted { get; set; }

    private SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }
}