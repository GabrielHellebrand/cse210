using System;

class Program
{
    static void Main(string[] args)
    {
    string differentScripture = "yes";
    while (differentScripture == "yes");
// This asks the user to write a verse as well as the scripture reference and continue to write verses until the user types quit.
        
        List<string>verses = new List<string>();
        System.Console.WriteLine("Please enter the scripture's reference. (for example John 3:16): ");
        string scriptureReference = Console.ReadLine();
        string scriptures = "";
        while (scriptures != "quit") 
        {
            System.Console.WriteLine("Please write a verse. (type quit to exit.)");
            scriptures = Console.ReadLine(); 
            if(scriptures != "quit")
            {
                verses.Add(scriptures);
            }
            else
            {
                break;
            }
        };

// This prompts the user for another verse to be added.     
        string nextVerse = "yes";
        while (nextVerse == "yes");
            Scripture scrip = new Scripture(scriptureReference, verses);
            Console.Clear();
            scrip.Display();
            System.Console.WriteLine("Press Enter or type Q to quit.");
        string user = Console.ReadLine();

// This hides random words in the verse and continues to hide words until the user types Q 
// which exits out of the program.         
        while (scrip.IsAllHidden() == false) 
        {
            Random rand = new Random();
            int number = rand.Next(3);
            if (scrip.HideWords(3) == true)
            {
                scrip.HideWords(3);
            }
            Console.Clear();
            scrip.Display();
            System.Console.WriteLine("Press Enter or type Q to quit.");
            user = Console.ReadLine();
            if (user == "Q")
            {
                break;
            }
            Console.Clear();
            scrip.Display();
            System.Console.WriteLine("Would you like to add a verse? (Y/N)");
            differentScripture = Console.ReadLine();
        }
        
    }
}