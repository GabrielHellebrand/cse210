using System;
class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public Customer(string name, Address address)
// This gets the name and address of the customer.
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
// This checks if the customer is in the US or in another country.
    {
        return Address.IsInUSA();
    }

    public override string ToString()
    {
        return $"{Name}, {Address}";
    }
}
