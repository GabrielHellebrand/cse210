using System;
using System.Collections.Generic;
class Program
{
    private void DisplayMenu()
    {
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit");
        Console.Write("Enter your choice: ");
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the number of points for the goal:");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the type of the goal (simple, eternal, or checklist):");
        string typeStr = Console.ReadLine();

        GoalType type;
        if (!Enum.TryParse(typeStr, out type))
        {
            Console.WriteLine("Invalid goal type. Please try again.");
            return;
        }

        Goal goal = new Goal(name, points, type);
        goals.Add(goal);

        Console.WriteLine($"The goal '{name}' worth {points} points and of type {type} has been added to your list of goals.");
    }

    private void ListGoals()
        {
    Console.WriteLine("List of Goals:");
    foreach (var goal in goals)
    {
        Console.WriteLine($"Name: {goal.Name} | Points: {goal.Points} | Type: {goal.Type} | Completed: {goal.IsCompleted}");
    }
}
private void SaveGoals()
{
    Console.WriteLine("Enter the file name to save the goals to:");
    string fileName = Console.ReadLine();

    try
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.Name},{goal.Points},{goal.IsCompleted},{goal.Type}");
            }
        }

        Console.WriteLine($"Goals have been saved to {fileName}.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving goals: {ex.Message}");
    }
}
private void LoadGoals()
{
    Console.WriteLine("Enter the name of the file to load goals from:");
    string fileName = Console.ReadLine();

    try
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string[] parts = line.Split(',');
                if (parts.Length != 4)
                {
                    Console.WriteLine($"Invalid line in file: {line}");
                    continue;
                }

                string name = parts[0];
                int points = int.Parse(parts[1]);
                bool isCompleted = bool.Parse(parts[2]);
                GoalType type = (GoalType)Enum.Parse(typeof(GoalType), parts[3]);

                Goal goal = new Goal(name, points, type);
                goal.IsCompleted = isCompleted;
                goals.Add(goal);
            }
        }

        Console.WriteLine($"Goals loaded from file '{fileName}'");
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine($"File '{fileName}' not found.");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error loading goals: {e.Message}");
    }
}
private void RecordEvent()
{
    Console.WriteLine("Enter the name of the goal you want to record progress for:");
    string goalName = Console.ReadLine();

    Goal goal = goals.Find(g => g.Name == goalName);

    if (goal == null)
    {
        Console.WriteLine($"Goal '{goalName}' not found. Please try again.");
        return;
    }

    Console.WriteLine($"Recording progress for goal '{goal.Name}' worth {goal.Points} points.");
    Console.WriteLine("Enter a description of the progress:");
    string description = Console.ReadLine();

    Console.WriteLine("Enter the date of the progress (yyyy-mm-dd):");
    string dateStr = Console.ReadLine();

    DateTime date;
    if (!DateTime.TryParse(dateStr, out date))
    {
        Console.WriteLine("Invalid date format. Please try again.");
        return;
    }

    goal.IsCompleted = true;
    Console.WriteLine($"Progress for goal '{goal.Name}' worth {goal.Points} points recorded on {date}: {description}");
    } 
}   