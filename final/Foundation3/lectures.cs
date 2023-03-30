using System;
class Lecture : Event
{
    protected string Speaker;
    protected int Capacity;
// This establishes the speaker and the capacity for the event in the case of a lecture.
    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity) : base(title, description, dateTime, address)
    {
        this.Speaker = speaker;
        this.Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + "\nType: Lecture\nSpeaker: " + Speaker + "\nCapacity: " + Capacity;
    }

    public override string GetShortDescription()
    {
        return "Type: Lecture\nTitle: " + title + "\nDate: " + dateTime.ToString("D");
    }
}