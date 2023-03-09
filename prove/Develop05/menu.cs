using System;

public class Menu
{
    private string Name { get; set; }
    private int Points { get; set; }
    private bool IsCompleted { get; set;} 

   private static void DisplayMenu()
    {     
        System.Console.WriteLine("1. Create New Goal");
        System.Console.WriteLine("2. List goals");
        System.Console.WriteLine("3. Save Goals");
        System.Console.WriteLine("4. Load Goals");
        System.Console.WriteLine("5. Record event");
        System.Console.WriteLine("6. Quit");
        string DisplayMenu = System.Console.ReadLine(); 
    }
private static void OtherMenu()
    {     
        System.Console.WriteLine("1. Simple Goal");
        System.Console.WriteLine("2. Eternal Goal");
        System.Console.WriteLine("3. Checklist Goal");
        string OtherMenu = System.Console.ReadLine(); 
    }


}