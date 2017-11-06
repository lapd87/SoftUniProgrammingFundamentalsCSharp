using System;

class MilesToKM
{
    static void Main()
    {
        double miles = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Round(miles*1.60934,2));
    }
}
