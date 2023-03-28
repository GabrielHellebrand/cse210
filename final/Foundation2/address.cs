using System;
class Address
{
    private string StreetAddress { get; set; }
    private string City { get; set; }
    private string StateProvince { get; set; }
    private string Country { get; set; }

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country == "USA";
    }

    public override string ToString()
    {
        return $"{StreetAddress}, {City}, {StateProvince}, {Country}";
    }
}