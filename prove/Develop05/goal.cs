using System;
using System.Collections.Generic;

enum GoalType
// This sets the different types of goals that there are in an enum.
{
    Simple,
    Eternal,
    Checklist
}

abstract class Goal
// This stores the name of the goal, how many points the goal is worth, if the goal is completed, and the type of the 
// goal whether that be simple, eternal, or checklist.
{
    protected string Name;
    protected int Points;
    protected bool IsCompleted;
    protected GoalType Type;

}