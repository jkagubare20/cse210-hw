using System;
public class Motorcycle : Vehicle
{
    private int _engineSize;

    public Motorcycle(string brand, int year, int engineSize) : base(brand, year)
    {
        _engineSize = engineSize;
    }

    public void Wheelie()
    {
        Console.WriteLine($"{_brand} is doing a wheelie!");
    }
}