using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Fabric", 123, 27.99, 4);
        Product product2 = new Product("Embroidery Stabilizer", 456, 49.50, 1);
        Product product3 = new Product("Fabric Adhesive", 678, 20.00, 1);
        Product product4 = new Product("Thread", 567, 9.20, 10);

        Address address1 = new Address("123 Main Street", "Anytown", "Naval", "Philippines", "6543");
        Customer customer1 = new Customer("Haven Sarabia", address1);


        Product product5 = new Product("Flour", 437, 20.50, 2);
        Product product6 = new Product("Baking powder", 348, 15.00, 1);
        Product product7 = new Product("Sugar", 193, 7.25, 1);
        Product product8 = new Product("Egg", 921, 5.00, 12);
        Product product9 = new Product("Butter", 281, 12.99, 1);
        Product product10 = new Product("Vanilla Extract", 672, 10.00, 1);
        Product product11 = new Product("Milk", 612, 20.00, 1);

        Address address2 = new Address("456 Main Street", "Somewheretown", "NY", "United States", "1234");
        Customer customer2 = new Customer("Alina Santos", address2);

        List<Order> orders = new List<Order>();
        orders.Add(new Order(new List<Product>{product1, product2, product3, product4}, customer1));
        orders.Add(new Order(new List<Product>{product5, product6, product7, product8, product9, product10, product11}, customer2));

        Console.WriteLine("");
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("--------------------");
            Console.WriteLine("Total Cost: $" + order.CalculateTotal());
            Console.WriteLine("");
        }
    }
}