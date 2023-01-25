using System;
    class Journal    
    {
// This opens the text file called journal. 
        public string TextFile = "journal.txt";
    
    public void Menu()
    {
// A Do While loop that loops through the options on the menu, the user can either load, deleate or add to there journal.
        string choice;
        do 
    {
        choice = ItemOfYourChoice();
        switch (choice)
        {
            case "1":
                DisplayJournal();
                break;
            case "2":
                ClearJournal();
                break;
            case "3":
                AddEntry();
                break;
            default:
                break;
        }
            
    } while (choice != "4");
}
    public string ItemOfYourChoice()
    {
       bool isChoiceValid = false;
       string choice = "";

       do
       {
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.WriteLine("What would you like to pick?");
        System.Console.WriteLine("1) Read Journal");
        System.Console.WriteLine("2) Erase Journal");
        System.Console.WriteLine("3) Write Journal");
        System.Console.WriteLine("4) Exit Journal");

        Console.ForegroundColor = ConsoleColor.Green;
        choice = Console.ReadLine().Trim();
        Console.ForegroundColor = ConsoleColor.Black;
        if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
        {
            isChoiceValid = true;
        }
// An else statement that says the number the user picked isn't a valid number.        
        else
        {
            System.Console.WriteLine($"I'm sorry {choice} isn't one of the options available, please pick a number between 1-4.");
        }
       } while(!isChoiceValid);
        return choice;

// This checks if journal.txt exists in the folder.
    }
    public void CreateFile() {
        if (!System.IO.File.Exists(TextFile))
        {
            File.CreateText(TextFile);
        }
    }
    public void DisplayJournal() 
    {
// This displays the journal that you've created thus far.
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.BackgroundColor = ConsoleColor.White;

        System.Console.WriteLine("This is your diary, please tell me your secrets.\n");
        System.Console.WriteLine("Such as your mother's maiden name or the last four digits of your social security number.\n");
        System.Console.WriteLine("Teehee, have fun.");
        {
            string journal = File.ReadAllText(TextFile);
            System.Console.WriteLine("Journal");
            System.Console.WriteLine(journal);
        }

    }

    public void ClearJournal()
// This erases the journal and allows for a clean slate.
    {
        Console.ForegroundColor = ConsoleColor.Black;
        File.WriteAllText(TextFile, "");
        System.Console.WriteLine("Memory erased, what's my name again?");
    }

    public void AddEntry()
// This allows a user to add entries to the journal.
    {
        Console.ForegroundColor = ConsoleColor.Black;
        System.Console.WriteLine("What would you like to write about today?(Type DONE and press enter to stop.) ");
        Console.ForegroundColor = ConsoleColor.DarkRed;

        string entry = "";
        bool Continue = true;
        while(Continue)
        {
            string line = Console.ReadLine();
            if (line.ToLower().Trim() == "done")
            {
                Continue = false;
            }
            else
            {
                entry += line + "\n";
            }
        }


        File.AppendAllText(TextFile, $"Entry: \n> {entry}");
        Console.ForegroundColor = ConsoleColor.Black;
        System.Console.WriteLine("The Journal has been changed!");
    }
}
    

        
    




