using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("Red", 2.50);
        // Console.WriteLine($"The color of the sqare is {square.GetColor()} and the area is {square.GetArea()}m2.");
        // Console.WriteLine();
        Rectangle rectangle = new Rectangle("Blue", 2.00, 4.00);
        // Console.WriteLine($"The color of the rectangle is {rectangle.GetColor()} and the area is {rectangle.GetArea()}m2.");
        // Console.WriteLine();
        Circle circle = new Circle("Yellow", 3.00);
        // Console.WriteLine($"The color of the circle is {circle.GetColor()} and the area is {circle.GetArea()}m2.");


    List<Shape> shapes = new List<Shape>();
    shapes.Add(square);
    shapes.Add(rectangle);
    shapes.Add(circle);

    foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}m2.");
        }

    }


}