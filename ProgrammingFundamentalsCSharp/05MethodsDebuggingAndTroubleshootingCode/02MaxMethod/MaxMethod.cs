using System;

class MaxMethod
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        double maxNum = GetMax(GetMax(num1, num2), GetMax(num2, num3));

        Console.WriteLine(maxNum);
    }

    private static double GetMax(double num1, double num2)
    {
        if (num1 >= num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
}
