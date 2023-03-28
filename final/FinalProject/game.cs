using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGalacticChronicles
{
    class Game
    LoadGame()
    SaveGame()

    {
    // print backstory
    static void Level(string[] args)
    {
        string CharacterName = "";
        string CharacterPlanet = "";
        Console.WriteLine("The Galactic Chronicles!");
        Console.WriteLine("Level 1");
        Console.WriteLine("You're finally awake! Welcome to the Milky Way Galaxy, you will be a mercenary working for the Order of the White Horse.");
        Console.WriteLine("An order that provides vigilante justice in a galaxy of chaos.");
        Console.WriteLine("What is your name?");
        CharacterName = Console.ReadLine();
        Console.WriteLine("What world do you come from?");
        CharacterPlanet = Console.ReadLine();
        Console.WriteLine($"Hello{CharacterName} I've never visited {CharacterPlanet} before, you'll have to tell me what it's like sometime.");
        Console.WriteLine("You'll be working with Brightfire, he'll show you the ropes");
        Console.WriteLine("Brightfire walks in, he has two dark wings with red tips coming out of his back, scaly grey skin and");
        Console.WriteLine($"two red eyes, Brightfire tells you 'Hey {CharacterName} have you ever fired a ray gun before?'");
        Console.WriteLine("You shake your head no. Brightfire tells you 'Alright I'll teach you'");
        Console.WriteLine("You train for combat and Brightfire asks you to pick between a flaming sword, a stungun or ray gun, 1/2/3");
        Console.WriteLine("A stun gun will paralyze the target but a second shot will kill the target.");
        Console.WriteLine("A ray gun will kill the target with one shot but isn't quite as accurate as a stun gun.");
        Console.WriteLine("A Flaming sword is great for close range combat, you control the sword's flame with a Brain computing interface.");
        Console.ReadKey();
        int choice = 1; // Define and initialize "choice" here
    switch (choice)
{
    case 1:
        Console.WriteLine("Excellent choice you picked the ray gun.");
        Console.ReadLine();
        break;
    case 2:
        Console.WriteLine("Excellent choice you picked the stun gun.");
        Console.ReadLine();
        break;
    case 3:
        Console.WriteLine("Excellent choice you picked the flaming sword.");
        Console.ReadLine();
        break;
}
    Console.WriteLine("After training Brightfire tells you the mission, a Regulan officer in the Regulan Civil War");
    Console.WriteLine("has lost the war. The losers of the Regulan Civil war were banished to the deserts of Sirius"); 
    Console.WriteLine("This Regulan officer named Chankuk has gained quite a following on Sirius and there are worries");
    Console.WriteLine("that he will reignite the Regulan Civil War. You and Brightfire arrive on Sirius.");
    Console.WriteLine("Brightfire gives you instructions from the ship and you find Chankuk giving a speech to fellow ");
    Console.WriteLine("Regulan refugees. What do you do, kill him now or wait for the crowd to disappear? 1/2");
    Console.ReadKey();
    int choice1 =1;
    switch(choice1)
{
    case 1:
        Console.WriteLine("Killing him in the midst of the crowd gets you arrested by those in the crowd and you're sent");
        Console.WriteLine("to a prison on an asteroid near Regulus.");

        Console.ReadLine();
        break;
    case 2:
        Console.WriteLine("Waiting till the crowd clears allows Chankuk to take a look at you, he invites you on the");
        Console.WriteLine("stage with him. Chankuk asks who you were but you use the weapon of your choice on him.");
        Console.WriteLine("The weapon grazes Chankuk who then pummels you to the ground him being ex military and you.");
        Console.WriteLine("having little experience in combat. Gives Chankuk the upper hand but Chankuk gets momentarily");
        Console.WriteLine("distracted due to Brightfire's ship passing overhead. This allows you to pin Chankuk.");
        Console.WriteLine("Chankuk tells you that the organization you work for isn't what you think it is");
        Console.WriteLine("and that the White Horse plays both sides in wars and conflicts.");
        Console.WriteLine("You kill Chankuk with your weapon and leave.");
        break;
}
    static void Level2(string[] args)
    {
        Console.WriteLine("Level 2");
        int choice1 = 1;
        switch(choice1)
        {
        case 1:
        Console.WriteLine("You befriend a fellow prisoner in the Regulan prison.");
        Console.WriteLine("The fellow prisoner lets you in on a plan to break out of the prison.");
        Console.WriteLine("");
        Console.ReadLine();
        break;
        case 2:
        Console.WriteLine("");
        break;
        }
    }
}
}
}
