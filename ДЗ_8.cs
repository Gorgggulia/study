using System;
using System.Collections.Generic;

abstract class Shape
{
    public string Name { get; }

    protected Shape(string name)
    {
        Name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Shape
{
    public double Radius { get; }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Square : Shape
{
    public double Side { get; }

    public Square(string name, double side) : base(name)
    {
        Side = side;
    }

    public override double Area()
    {
        return Math.Pow(Side, 2);
    }

    public override double Perimeter()
    {
        return 4 * Side;
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        Console.WriteLine("Enter data for 10 different shapes:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Shape {i}:");

            Console.Write("Enter shape name: ");
            string name = Console.ReadLine();

            Console.Write("Enter shape type (1 for Circle, 2 for Square): ");
            int type = Convert.ToInt32(Console.ReadLine());

            switch (type)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Circle(name, radius));
                    break;
                case 2:
                    Console.Write("Enter side length: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Square(name, side));
                    break;
                default:
                    Console.WriteLine("Invalid shape type.");
                    i--; // Decrement the counter to repeat the current iteration
                    break;
            }
        }

        Console.WriteLine("\nShapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Name: {shape.Name}");
            Console.WriteLine($"Area: {shape.Area()}");
            Console.WriteLine($"Perimeter: {shape.Perimeter()}");
            Console.WriteLine();
        }

        Shape shapeWithLargestPerimeter = GetShapeWithLargestPerimeter(shapes);
        Console.WriteLine($"Shape with the largest perimeter: {shapeWithLargestPerimeter.Name}");

        shapes.Sort();
        Console.WriteLine("\nShapes sorted by area:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Name: {shape.Name}");
            Console.WriteLine($"Area: {shape.Area()}");
            Console.WriteLine($"Perimeter: {shape.Perimeter()}");
            Console.WriteLine();
        }
    }

    static Shape GetShapeWithLargestPerimeter(List<Shape> shapes)
    {
        Shape largestShape = shapes[0];
        foreach (Shape shape in shapes)
        {
            if (shape.Perimeter() > largestShape.Perimeter())
            {
                largestShape = shape;
            }
        }
        return largestShape;
    }
}