using System.Collections.Generic;
using System.Collections.Generic;

class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order(List<Product> products, Customer customer)
// This gets the order itself from the customer.
    {
        Products = products;
        Customer = customer;
    }

    public double GetTotalPrice()
// This calculates the total price using a foreach loop. It also checks if the customer is in the US.
// If the customer is in the US it's a $5.00 delivery fee, if the customer is outside of the US it's a $35.00 delivery fee.
    {
        double totalPrice = 0;
        foreach (Product product in Products)
        {
            totalPrice += product.GetTotalPrice();
        }
        if (Customer.IsInUSA())
        {
            totalPrice += 5.0;
        }
        else
        {
            totalPrice += 35.0;
        }
        return totalPrice;
    }

    public string GetPackingLabel()
// This gets the packing and shipping label for the product.
    {
        string label = "";
        foreach (Product product in Products)
        {
            label += product.ToString() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return Customer.ToString();
    }
}