using System;
using System.Collections.Generic;

class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
         // Create a list of goals
        List<Goal> goals = new List<Goal>();
        goals.Add(new Goal("Complete a marathon", 500));
        goals.Add(new Goal("Walk the dog", 10));
        goals.Add(new Goal("Go to the gym", 100));
        goals.Add(new Goal("Get groceries", 50));

    }
}

