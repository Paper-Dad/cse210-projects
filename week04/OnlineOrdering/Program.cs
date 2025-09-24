using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Address addr2 = new Address("324 Highlands Blvd W", "Lethbridge", "AB", "Canada");

        Customer cust1 = new Customer("Alice Johnson", addr1);
        Customer cust2 = new Customer("Ben Roberts", addr2);

        Product p1 = new Product("Laptop", "LAP123", 900.00, 1);
        Product p2 = new Product("Mouse", "MOU456", 25.50, 2);
        Product p3 = new Product("Keyboard", "KEY789", 45.00, 1);

        Order order1 = new Order(cust1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Order order2 = new Order(cust2);
        order2.AddProduct(p2);
        order2.AddProduct(p3);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}\n");
        }
    }
}
