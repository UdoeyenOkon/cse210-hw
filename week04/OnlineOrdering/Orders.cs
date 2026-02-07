using System.Runtime.CompilerServices;

public class Orders
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public void AddProducts(Product newProducts)
    {
        _products.Add(newProducts);
    }

    public void AddCustomer(Customer newCustomer)
    {
        _customer = newCustomer;
    }

    public void TotalPrice()
    {
        double shippingCost = _customer != null ? _customer.GetShippingCost() : 0;
        double totalPrice = 0;
        foreach (var product in _products)
        {
            {
                totalPrice += product.TotalCost();
            }
        }
        totalPrice += shippingCost;
        Console.WriteLine($"Total Price: ${totalPrice}");
        }

        public void PackageLabel()
        {
        Console.WriteLine("Package Label:");
        foreach (var product in _products)
            {
                Console.Write(product.GetProductName()) ;
                Console.WriteLine(product.GetProductId());
            }
    }

        public void ShippingLabel()
        {
            Console.WriteLine("Shipping Label:");
            _customer.DisplayCustomerInfo();
            // Console.WriteLine("Shipping Label:");
            // foreach (var product in _products)
        //     {
        //     Address address = new Address("152 Ekpri Nsukara Street", "Uyo", "Akwa Ibom State", "Nigeria");
        //     Customer customer = new Customer("Michael Abort", address);
            
        //     }
        }
        public void CustomerLiveInUSA()
        {
            if (_customer != null)
            {
                _customer.CustomerLiveInUSA();
            }
        }

}

