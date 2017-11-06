using System;

class GeometryCalculator
{
    static void Main()
    {
        string figureType = Console.ReadLine();

        double area = 0;

        switch (figureType)
        {
            case "triangle": area = TriangleArea(); break;
            case "square": area = SquareArea(); break;
            case "rectangle": area = RectangleArea(); break;
            case "circle": area = CircleArea(); break;
        }

        Console.WriteLine($"{area:f2}");
    }

    private static double CircleArea()
    {
        double radius = double.Parse(Console.ReadLine());
        return Math.PI * radius * radius;
    }

    private static double RectangleArea()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        return width * height;
    }

    private static double SquareArea()
    {
        double side = double.Parse(Console.ReadLine());
        return side * side;
    }

    private static double TriangleArea()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        return side * height / 2.0;
    }
}
