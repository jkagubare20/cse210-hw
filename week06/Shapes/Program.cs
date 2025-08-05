using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 5);
        shapes.Add(square);

        Circle circle = new Circle("Blue", 3);
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle("Green", 4, 6);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
        
        
    }
}