using System;

class CenterPoint
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine(ClosestPoint(x1, y1, x2, y2));
    }

    static string ClosestPoint(double x1, double y1, double x2, double y2)
    {
        double line1 = Math.Sqrt(x1 * x1 + y1 * y1);
        double line2 = Math.Sqrt(x2 * x2 + y2 * y2);

        if (line1 <= line2)
        {
            return $"({x1}, {y1})";

        }
        else
        {
            return $"({x2}, {y2})";
        }
    }
}
