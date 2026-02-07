public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;    
    }

    // public string GetCustomerName()
    // {
    //     return _customerName;
    // }

    // public Address GetCustomerAddress()
    // {
    //     return _address;
    // }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer's Name: {_customerName}.");
        Console.WriteLine($"Customer's Address: {_address}.");
    }

    public void CustomerLiveInUSA()
    {
        if (_address.GetCountry() == "USA")
        {
            Console.WriteLine("The customer lives in the USA");
        }
        else
        {
            Console.WriteLine("The customer lives outside of the USA");
        }
    }

    public int GetShippingCost()
    {
        return _address.LiveInUSA();
    }

}