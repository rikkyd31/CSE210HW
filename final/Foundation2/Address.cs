public class Address
{
    // String Attributes
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _zipCode;
    private string _country;
    private string _fullAddress;

    // Bool Attribute
    private bool _usa;
    
    // Constructor
    public Address()
    {
        
    }

    // Getters
    public bool GetUsa()
    {
        if (_country.ToLower() == "united states of america" || _country.ToLower() == "united states" || _country.ToLower() == "usa" || _country.ToLower() == "us")
        {
            _usa = true;
        }
        else
        {
            _usa = false;
        }

        return _usa;
    }

    public string GetAddress()
    {
        _fullAddress = $"{_streetAddress} \n {_city}, {_stateProvince} {_zipCode} \n {_country}";

        return _fullAddress;
    }

    // Setters
    public void SetAddress(string streetAddress, string city, string stateProvince, string zipCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _zipCode = zipCode;
        _country = country;
    }
}