using System;
using System.Collections.Generic;
class Program
{
    static List<Goal> goals = new List<Goal>();
    public static void main(string args)
    {
    
    int totalPoints = 0;
    Console.WriteLine("Welcome to the goal tracker! What goals do you want to work on?");
    
        Console.WriteLine("1. Create A New Goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit");
        Console.Write("Enter your choice human: ");
    
    string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goals);
                    break;
                case "2":
                    ListGoals(goals);
                    break;
                case "3":
                    SaveGoals(goals);
                    break;
                case "4":
                    LoadGoals(goals);
                    break;
                case "5":
                    RecordEvent(goals);
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
    }
    }
    public static void CreateGoal(List<Goal> goals)
{
    Goal goal = new Goal(name, points, type);
    goals.Add(goal);
}

    public static void ListGoals(List<Goal> goals)
// This lists the goals out that the user has entered. The name of the goal, the points that goal is worth and whether 
// or not it's completed.
        {
    Console.WriteLine("List of Goals:");
    foreach (var goal in goals)
    {
        Console.WriteLine($"Name: {goal.name} | Points: {goal.points} | Type: {goal.type} | Completed: {goal.IsCompleted}");
    }
}
    public static void SaveGoals(List<Goal> goals)
// This saves the goals to the filename, goals.txt
{
    Console.WriteLine("Enter the file name to save the goals to:");
    string fileName = Console.ReadLine("goals.txt");

    try
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.name},{goal.points},{goal.IsCompleted},{goal.type}");
            }
        }

        Console.WriteLine($"Goals have been saved to {fileName}.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving goals: {ex.Message}");
    }
}
// needs destructer to close the file
~SaveGoals()
{
    // close the file
    _file.Close();
}
  public static void LoadGoals(List<Goal> goals)
// This loads the goals from the filename and catches if the file isn't found.
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
    catch (Exception exception)
    {
        Console.WriteLine($"Error loading goals: {exception.Message}");
    }
}
// needs destructer to close the file
~LoadGoals()
{
    // close the file
    _file.Close();
}
    public static void RecordEvent(List<Goal> goals)
// This records the progress for your goals and when you completed your goals. 
{
    Console.WriteLine("Enter the name of the goal you want to record progress for:");
    string goalName = Console.ReadLine();

    Goal goal = goals.Find(goal => goal.name == goalName);

    if (goal == null)
    {
        Console.WriteLine($"Goal '{goalName}' not found. Please try again.");
        return;
    }

    Console.WriteLine($"Recording progress for goal '{goal.name}' worth {goal.points} points.");
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
    Console.WriteLine($"Progress for goal '{goal.name}' worth {goal.points} points recorded on {date}: {description}");
    } 
}   