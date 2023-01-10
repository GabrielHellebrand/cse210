using System;

class Program
{
    static void Main(string[] args)
    {
        string secretNumber = "69";
        string guess = "";
        while(guess != secretNumber)
        {
            Console.Write("Guess the number: ");
            guess = Console.ReadLine();

        }
        Console.Write("You got it!");
        Console.ReadLine();
    }
}