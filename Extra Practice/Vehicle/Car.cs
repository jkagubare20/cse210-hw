using System;
public class Car : Vehicle
{
    private int _numberOfDoors;

    public Car(string brand, int year, int numberOfDoors) : base(brand, year)
    {
        _numberOfDoors = numberOfDoors;
    }

    public void Honk()
    {
        Console.WriteLine($"{_brand} is HONKING!");
    }
}