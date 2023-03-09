using System;
class BreathingActivity : Activity
{
    public BreathingActivity(string name,
        string desc,
        string welcome,
        string ending,
        int duration
        )
    {

    }
    
    public void DoTheThing()
    {
        DisplayDelay(3);
        Console.WriteLine("Oxygen is the number 1 killer in the world."); 
        Console.WriteLine("Think about it, everyone who has breathed oxygen has died at somepoint or will die,");
        Console.WriteLine("and don't get me started on Di-Hydrogen Monoxide in our water.");
    
        DisplayDelay(2);
    }


}
