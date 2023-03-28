using System.Collections.Generic;
using System.Collections.Generic;

class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order(List<Product> products, Customer customer)
    {
        Products = products;
        Customer = customer;
    }

    public double GetTotalPrice()
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