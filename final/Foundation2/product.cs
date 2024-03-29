using System;
    class Product
{
    public string Name { get; set; }
    public string Id { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string id, double price, int quantity = 1)
// This gets the name, the id, the price and how many of the product the customer wants.
    {
        Name = name;
        Id = id;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return Price * Quantity;
    }

    public override string ToString()
    {
        return $"{Name} (ID: {Id}) - ${Price} x {Quantity}";
    }
}
