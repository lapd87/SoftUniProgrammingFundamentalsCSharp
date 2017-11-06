using System;

class CalculateTriangleArea
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = TriangleArea(side, height);

        Console.WriteLine(area);
    }

    private static double TriangleArea(double side, double height)
    {
        double area = side * height / 2.0;

        return area;
    }
}
