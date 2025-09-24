public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        if (_customer.IsInUSA() == true)
        {
            total += 5;
            return total;
        }
        else
        {
            total += 35;
            return total;
        }
    }

    public string GetPackingLabel()
    {
        string result = "Packing Label:\n";
        foreach (Product p in _products)
        {
            result += p.GetPackingLabel() + "\n";
        }
        return result;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}
