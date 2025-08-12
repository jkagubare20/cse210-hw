using System;
public class Vehicle
{
    private string _brand;
    private int _year;

    public Vehicle(string brand, int year)
    {
        _brand = brand;
        _year = year;
    }

    public string GetBrand()
    {
        return _brand;
    }
    public void Start()
    {
        Console.WriteLine($"{_brand} is starting");

    }

    public void Stop()
    {
        Console.WriteLine($"{_brand} is stopping");
    }
}