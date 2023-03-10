class ChecklistGoal: Goal
{
    
    public ChecklistGoal()
    {
        // This allows the user to enter the name of the goal as well as the number of points the goal is worth.
// It also allows the user to assign whether the goal is simple, a checklist goal or an eternal goal.
        Console.WriteLine("Enter the name of the goal:");
        Name = Console.ReadLine();

        Console.WriteLine("Enter the number of points the goal is worth:");
        Points = int.Parse(Console.ReadLine());

    }
}