using System;

class CircleAreaPrecision12
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double circleArea = radius * radius * Math.PI;

        Console.WriteLine("{0:f12}", circleArea);
    }
}
