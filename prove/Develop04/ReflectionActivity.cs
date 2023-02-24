using System;
class ReflectionActivity : Activity
{
  
    public ReflectionActivity(int duration) 
    {

    }
    public ReflectionActivity(string name,
            string desc,
            string welcome,
            string ending,
            int duration)
    {
    }
    public void Message()
    {
        DisplayDelay(3);
        Console.WriteLine("Think of a time when you helped someone in need.");
        Console.WriteLine("Think of a time when you did something truly selfless.");
        Console.WriteLine("Think of a time when you came home, you're wife was away but the coffee table was broken and you call the police\nthinking you had a burgular in the house.");
        Console.WriteLine("Think of a time when due to your wife missing and you having no alibi you end up the number 1 suspect in her disappearence. ");
        Console.WriteLine("Think of a time when your wife faked her murder and kidnapping to get back at you for cheating on her and comes home.");
        Console.WriteLine("How does that make you feel?");
        Console.WriteLine("I know for me I thought Gone Girl had a great premise but I didn't like the ending.");
        DisplayDelay(2);
    }


  
    
}