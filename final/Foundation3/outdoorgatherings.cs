using System;
class OutdoorGathering : Event
{
    protected string weatherForecast;
    
// This makes sure the weather forecast is good in the case that the event is outdoors.    
    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast) : base(title, description, dateTime, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + "\nType: Outdoor Gathering\nWeather: " + weatherForecast;
    }

    public override string GetShortDescription()
    {
        return "Type: Outdoor Gathering\nTitle: " + title + "\nDate: " + dateTime.ToString("D");
    }
}   