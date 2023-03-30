using System;
class Event
{
    protected string title;
    protected string description;
    protected DateTime dateTime;
    protected Address address;

    public Event(string title, string description, DateTime dateTime, Address address)
// This gets the details of the event such as what the event is called, a brief description of the event
// the time the event takes place and where the event is at.
    {
        this.title = title;
        this.description = description;
        this.dateTime = dateTime;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return "Title: " + title + "\nDescription: " + description + "\nDate: " + dateTime.ToString("D") + "\nTime: " + dateTime.ToString("t") + "\nAddress: " + address.GetAddress();
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return "Type: Event\nTitle: " + title + "\nDate: " + dateTime.ToString("D");
    }
}