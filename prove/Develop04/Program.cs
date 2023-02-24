using System;

class Program
{
    static void Main(string[] args)
    {
    BreathingActivity breathe = new BreathingActivity("Breathe",
        "Activity which helps people breath",
        "Remember to breathe", "There you can breathe now", 60);
    breathe.Display();
    breathe.DoTheThing();
    
    ListingActivity list = new ListingActivity(60);
    list.Display();
    list.DoStuff();

    ReflectionActivity reflect = new ReflectionActivity(60);
    reflect.Display();
    reflect.Message();
    }
    
} 
    