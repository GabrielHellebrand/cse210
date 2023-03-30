using System;
class Reception : Event
// This allows the people to rsvp to a reception and gets the description for the reception.
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail) : base(title, description, dateTime, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + "\nType: Reception\nRSVP Email: " + rsvpEmail;
    }

    public override string GetShortDescription()
    {
        return "Type: Reception\nTitle: " + title + "\nDate: " + dateTime.ToString("D");
    }
}