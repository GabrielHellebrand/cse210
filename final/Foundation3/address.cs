using System;

class Address
{
    private string street;
    private string city;
    private string state;
    private string zip;

    public Address(string street, string city, string state, string zip)
// This gets the address for where the lecture occurs.
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }

    public string GetAddress()
    {
        return street + ", " + city + ", " + state + " " + zip;
    }
}