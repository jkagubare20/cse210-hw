using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public bool InUSA()
    {
        if (string.IsNullOrEmpty(_country))
        {
            return false; // Handle case where country is not set
        }
        return _country.ToLower() == "united states" || _country.ToLower() == "usa" || _country.ToLower() == "us" || _country.ToLower() == "united states of america" || _country.ToLower() == "america";
    }

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }   

    public string GetFormattedAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
    }
}