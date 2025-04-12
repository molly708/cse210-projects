class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Step 1: Create Address objects
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm Ave", "Los Angeles", "CA", "USA");

        // Step 2: Create Customer objects using the addresses
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Alice Smith", address2);

        // Step 3: Create Product objects (2-3 for each order)
        Product product1 = new Product("Laptop", "P123", 999.99, 1);
        Product product2 = new Product("Mouse", "P456", 25.50, 2);
        Product product3 = new Product("Keyboard", "P789", 45.75, 1);

        Product product4 = new Product("Monitor", "P987", 199.99, 1);
        Product product5 = new Product("USB Drive", "P654", 15.99, 3);
        Product product6 = new Product("Headphones", "P321", 79.95, 1);

        // Step 4: Create Order objects with Customers and Product lists
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Step 5: Display Order Details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Cost: $" + order2.CalculateTotalCost());
    }
}