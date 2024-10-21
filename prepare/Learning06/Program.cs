using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 20));
        shapes.Add(new Circle("blue", 5));
        shapes.Add(new Rectangle("green", 10, 6));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} - Area: {shape.GetArea()}");
        }

    }
}