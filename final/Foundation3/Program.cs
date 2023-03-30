using System;



class Program
{
    static void Main(string[] args)
    // This gets the strings for the program like event 1 being quite eventful.
    {
    Address address1 = new Address("123 Gunlock St", "Anytown", "UT", "12345");
    Address address2 = new Address("456 Elk St", "Somewhere", "ID", "67890");
    DateTime dateTime1 = new DateTime(2023, 4, 1, 14, 0, 0);
    DateTime dateTime2 = new DateTime(2023, 5, 1, 18, 0, 0);
    DateTime dateTime3 = new DateTime(2023, 6, 1, 12, 0, 0);

    Event event1 = new Event("Event 1", "This is event 1, one could say it was quite eventful", dateTime1, address1);
    Lecture lecture1 = new Lecture("Lecture 1", "I like hearing the sound of my own voice This is lecture 1", dateTime2, address2, "Jimmy Neutron", 50);
    Reception reception1 = new Reception("Reception 1", "After getting married seven times this is my first reception", dateTime3, address1, "rsvp@aol.com");
    OutdoorGathering outdoorGathering1 = new OutdoorGathering("Outdoor Gathering 1", "This is outdoor gathering 1, we're in Philadelphia right now and well it's always sunny", dateTime1, address2, "#ItsAlwaysSunnyInPhiladelphia");

    Console.WriteLine("Standard Details:");
    Console.WriteLine(event1.GetStandardDetails());
    Console.WriteLine(lecture1.GetStandardDetails());
    Console.WriteLine(reception1.GetStandardDetails());
    Console.WriteLine(outdoorGathering1.GetStandardDetails());

    Console.WriteLine("\nFull Details:");
    Console.WriteLine(event1.GetFullDetails());
    Console.WriteLine(lecture1.GetFullDetails());
    Console.WriteLine(reception1.GetFullDetails());
    Console.WriteLine(outdoorGathering1.GetFullDetails());

    Console.WriteLine("\nShort Description:");
    Console.WriteLine(event1.GetShortDescription());
    Console.WriteLine(lecture1.GetShortDescription());
    Console.WriteLine(reception1.GetShortDescription());
    Console.WriteLine(outdoorGathering1.GetShortDescription());
}
}