using System;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Mitsubishi", 2020, 4);
        myCar.Start();
        myCar.Honk();
        myCar.Stop();

        Console.WriteLine();

        Motorcycle motorcycle = new Motorcycle("Harley-Davidson", 2021, 1200);
        motorcycle.Start();
        motorcycle.Wheelie();
        motorcycle.Stop();
    }
}