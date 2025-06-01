using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);

        Product product1 = new Product("Smartphone", "P100", 799.99, 1);
        Product product2 = new Product("Wireless Earbuds", "P200", 59.99, 2);
        Product product3 = new Product("Charger", "P300", 19.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
            Console.WriteLine();
        }
    }
}