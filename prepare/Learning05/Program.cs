using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Blue", 4.00);
        Square square2 = new Square("Red", 4.00);
        Rectangle rectangle1 = new Rectangle("Green", 2.00, 6.00);
        Rectangle rectangle2 = new Rectangle("Blue", 2.00, 3.00);
        Circle circle1 = new Circle("Yellow", 3.00);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(square2);
        shapes.Add(rectangle1);
        shapes.Add(rectangle2);
        shapes.Add(circle1);

        int i = 1;
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape {i} is {shape.GetColor()} and has an area of {shape.GetArea()}");
            i++;
        }
    }
}