using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGalacticChronicles
{
    class Program
    {
    // print backstory
        static void Main()
        {
           Console.Title = "";
           System.Console.WriteLine("Boolean"); 
        string CharacterName = "";
        string CharacterPlanet = "";
        System.Console.WriteLine("The Galactic Chronicles!");
        System.Console.WriteLine("Welcome to the Milky Way Galaxy, you will be a mercenary working for the Order of the White Horse.");
        System.Console.WriteLine("An order that provides vigilante justice in a galaxy of chaos.");
        System.Console.WriteLine("What is your name?");
        CharacterName = Console.ReadLine();
        System.Console.WriteLine("What world do you come from?");
        CharacterPlanet= Console.ReadLine();
        System.Console.WriteLine($"Hello{CharacterName} I've never visited {CharacterPlanet} before, you'll have to tell me what it's like.");
        Console.ReadKey();
        }
    }
}