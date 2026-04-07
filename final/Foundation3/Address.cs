public class Address
{
    // Attributes
    private string _address;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _fullAddress;

    // Setters
    public void SetAddress(string address, string city, string state, string zipCode)
    {
        _address = address;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    // Getters
    public string GetAddress()
    {
        return _address;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetZip()
    {
        return _zipCode;
    }

    // This method combines the various address strings into one string called _fullAddress.
    public string CombineAddress()
    {
        // Create a full address with two lines. Leave indenting to line up address lines.
        _fullAddress = $"{_address}\n         {_city}, {_state} {_zipCode}";

        return _fullAddress;
    }
}