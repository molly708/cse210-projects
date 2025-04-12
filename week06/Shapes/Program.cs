using System;
using System.Drawing;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("Blue", 7);
        square.GetColor();
        square.GetArea();

        Shapes.Rectangle rectangle = new Shapes.Rectangle("Sage", 9, 5);
        rectangle.GetColor();
        rectangle.GetArea();

        Circle circle = new Circle("Indigo", 11);
        circle.GetColor();
        circle.GetArea();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The color of the shape is {color}. The area of the shape is {area}");
        }        
    }
}