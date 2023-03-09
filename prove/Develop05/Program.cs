using System;

class Program
{
static void Main(string[] args){
      // Create a list of goals
    List<Goal> goals = new List<Goal>();
    SimpleGoal simpGoal = new SimpleGoal("Complete a marathon", 500);
        goals.Add(new SimpleGoal("Run a marathon",500));
        goals.Add(new SimpleGoal("Walk the dog", 10));
        goals.Add(new SimpleGoal("Go to the gym", 100));
        goals.Add(new SimpleGoal("Get groceries", 50));
 
    {
        int score = 0;
        Console.WriteLine("Welcome to the goal tracker!");

        // Loop through the goals and allow the user to complete them
        while (true)
        {
            Console.WriteLine("\nHere are your goals:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.Write($"{i + 1}. {goals[i].Name}");
                if (goals[i].IsCompleted)
                {
                    Console.WriteLine(" - Completed");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nWhat goal did you complete? (Enter 0 to exit)");
            int choice = int.Parse(Console.ReadLine()); 

            if (choice == 0)
            {
                break;
            }
            else if (choice < 1 || choice > goals.Count)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            Goal completedGoal = goals[choice - 1];
            if (completedGoal.IsCompleted)
            {
                Console.WriteLine("You've already completed this goal. Please try another.");
                continue;
            }

            completedGoal.IsCompleted = true;
            score += completedGoal.Points;
            Console.WriteLine($"Congratulations! You've completed {completedGoal.Name} and earned {completedGoal.Points} points.");

            Console.WriteLine($"\nYour current score is: {score}");
        }

        // Allow the user to add new goals
        Console.WriteLine("\nWould you like to add a new goal? (y/n)");
        string answer = Console.ReadLine();

        while (answer == "y")
        {
            Console.WriteLine("\nWhat is the name of the new goal?");
            string name = Console.ReadLine();

            Console.WriteLine("How many points is this goal worth?");
            int points = int.Parse(Console.ReadLine());

            goals.Add(new Goal(name, points));
            Console.WriteLine($"The goal '{name}' worth {points} points has been added to your list of goals.");

            Console.WriteLine("\nWould you like to add another goal? (y/n)");
            answer = Console.ReadLine();
        }

        Console.WriteLine($"\nYour final score is: {score}. Good job!");
    }
}
}