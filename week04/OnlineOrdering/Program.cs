using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");

        Customer customer = new Customer("John Doe", address);

        Product product1 = new Product("Laptop", "P001", 999.99m, 1);

        Product product2 = new Product("Wireless Mouse", "P002", 25.50m, 2);

        Order orders = new Order(customer);

        orders._products.Add(product1);
        orders._products.Add(product2);

        // Display order details
        Console.WriteLine(orders.GetPackingLabel());
        Console.WriteLine(orders.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${orders.GetTotalCost()}");
    }
}

