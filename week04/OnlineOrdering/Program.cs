using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Orders orders1 = new Orders();
        Product product1 = new Product("Table Fan", "-P001", 2500.00, 3);
        Product product2 = new Product("Dinning Table", "-p002", 10500.00, 2);
        Address address = new Address("152 Ekpri Nsukara Street", "Uyo", "Akwa Ibom State", "Nigeria");
        Customer customer = new Customer("Udoeyen Okon", address);
        orders1.AddProducts(product1);
        orders1.AddProducts(product2);
        orders1.AddCustomer(customer);

        Orders orders2 = new Orders();
        Product product3 = new Product("Cooker Cylinder", "-p003", 8000.00, 1);
        Product product4 = new Product("Television", "-p004", 20000.00, 4);
        Product product5 = new Product("Dining Chair", "-p005", 5000.00, 6);
        Address address2 = new Address("344 Airport Street", "Doling City", "New York", "USA");
        Customer customer2 = new Customer("Michael Abort", address2);
        orders2.AddProducts(product3);
        orders2.AddProducts(product4);
        orders2.AddProducts(product5);
        orders2.AddCustomer(customer2);

        List<Orders> orders = new List<Orders>{ orders1, orders2 };
        foreach (Orders order in orders)
        {
            order.PackageLabel();
            order.ShippingLabel();
            order.TotalPrice();
            order.CustomerLiveInUsa();
            Console.WriteLine();            
        }

    }
}