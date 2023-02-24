using System;
class ListingActivity: Activity
{
    public ListingActivity(int duration)
    {

    }
    public ListingActivity(string name,
            string desc,
            string welcome,
            string ending,
            int duration)
    {
    }
    public void DoStuff()
    {
        DisplayDelay(3);
        Console.WriteLine("Think of a list of anything you want, they can be your family members,"); 
        Console.WriteLine("hobbies, personal strengths, goals, personal heroes, a grocery list,"); 
        Console.WriteLine("a hitlist for the mob, a list of people that were friends with Jeffery Epstein."); 
        Console.WriteLine("A list of people who benefited from Jeffery Epstein's death.");
        Console.WriteLine("At this point you realize, Jeffery Epstein didn't kill himself.");
      
        DisplayDelay(2);
    }


}
