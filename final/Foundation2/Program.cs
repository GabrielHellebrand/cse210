using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("123 Steak St", "Pawnee", "IN", "USA");
        Address canadaAddress = new Address("456 Maple Ave", "Brantford", "ON", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("Ron Swanson", usaAddress);
        Customer canadaCustomer = new Customer("Wayne Gretzky", canadaAddress);

        // Create products
        Product book = new Product("Book", "12345", 9.99);
        Product movie = new Product("movie", "67890", 19.99);
        Product videogame = new Product("videogame", "13579", 49.99);

        // Create orders
        List<Product> usaOrderProducts = new List<Product>();
        usaOrderProducts.Add(book);
        usaOrderProducts.Add(movie);
        Order usaOrder = new Order(usaOrderProducts, usaCustomer);

        List<Product> canadaOrderProducts = new List<Product>();
        canadaOrderProducts.Add(book);
        canadaOrderProducts.Add(videogame);
        Order canadaOrder = new Order(canadaOrderProducts, canadaCustomer);

        // Display packing labels, shipping labels, and total prices
        Console.WriteLine("USA Order:");
        Console.WriteLine("Packing Label: " + usaOrder.GetPackingLabel());
        Console.WriteLine("Shipping Label: " + usaOrder.GetShippingLabel());
        Console.WriteLine("Total Price: $" + usaOrder.GetTotalPrice());

        Console.WriteLine("\nCanada Order:");
        Console.WriteLine("Packing Label: " + canadaOrder.GetPackingLabel());
        Console.WriteLine("Shipping Label: " + canadaOrder.GetShippingLabel());
        Console.WriteLine("Total Price: $" + canadaOrder.GetTotalPrice());

        Console.ReadLine();
    }
}