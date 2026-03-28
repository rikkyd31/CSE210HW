using System.Runtime.CompilerServices;

public class Customer
{
    // String Attributes
    private string _customerName;
    private string _customerAddress;
    private Address _address = new Address();
    private bool _liveUsa;

    // Constructor
    public Customer()
    {
        
    }

    // Getters
    public bool GetCustomerUsa()
    {
        _liveUsa = _address.GetUsa();

        return _liveUsa;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        _customerAddress = _address.GetAddress();

        return _customerAddress;
    }

    // Setters
    public void SetCustomerName(string customer)
    {
        _customerName = customer;
    }

    public void SetCustomerAddress(string streetAddress, string city, string stateProvince, string zipCode, string country)
    {
        // References the address method, to set the address inside the Address object
        _address.SetAddress(streetAddress, city, stateProvince, zipCode, country);
    }
}