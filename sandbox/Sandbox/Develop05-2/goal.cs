using System;
using System.Collections.Generic;

enum GoalType
// This sets the different types of goals that there are in an enum.
{
    Simple,
    Eternal,
    Checklist
}

class Goal
// This stores the name of the goal, how many points the goal is worth, if the goal is completed, and the type of the 
// goal whether that be simple, eternal, or checklist.
{
    private string Name { get; set; }
    private int Points { get; set; }
    private bool IsCompleted { get; set; }
    private GoalType Type { get; set; }

    private Goal(string name, int points, GoalType type)
// This method gets from the user the name of the goal, the amount of points
    {
        Name = name;
        Points = points;
        IsCompleted = false;
        Type = type;
    }
}