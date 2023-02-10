using System;

class Program
{
    static void Main(string[] args)
    {

        List<string> verses = new List<string>
        
            {
            "John 3:16",
            "For God so loved the world, that he gave his only begotten son,",
            "that whosoever believeth in him should not perish, but have eternal life."
            };  
            
        Scripture scrip = new Scripture("ref", verses);
        scrip.Display();
        scrip.HideWords(3);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 99);
        scrip.IsAllHidden();
    }
}