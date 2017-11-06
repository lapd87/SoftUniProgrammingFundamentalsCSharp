using System;

class LongerLine
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        Console.WriteLine(Longer(x1, y1, x2, y2, x3, y3, x4, y4));
    }

    static string Longer(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double line1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));



        double line2 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));

        if (line1 >= line2)
        {

            return ClosestPoint(x1, y1, x2, y2);

        }
        else
        {
            return ClosestPoint(x3, y3, x4, y4);
        }
    }

    static string ClosestPoint(double x1, double y1, double x2, double y2)
    {
        double line1 = Math.Sqrt(x1 * x1 + y1 * y1);
        double line2 = Math.Sqrt(x2 * x2 + y2 * y2);

        if (line1 <= line2)
        {
            return $"({x1}, {y1})({x2}, {y2})";

        }
        else
        {
            return $"({x2}, {y2})({x1}, {y1})";
        }
    }
}
