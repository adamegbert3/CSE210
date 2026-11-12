using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 5));
        shapes.Add(new Rectangle("blue", 3, 7));
        shapes.Add(new Circle("white", 2));



        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The color of the shape is {shape.GetColor()} and the area is {shape.GetArea()}\n\n");
        }
    }
}