using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Address 
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zip;

    public Address(string street, string city, string state, string country, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zip = zip;

    }

    public bool IsInUsa()
    {
        return _country.Equals("United States", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_country}, {_zip}";
    }

}
