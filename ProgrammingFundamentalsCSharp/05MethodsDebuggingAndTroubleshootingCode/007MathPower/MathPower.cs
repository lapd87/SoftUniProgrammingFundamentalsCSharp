using System;

class MathPower
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        double result = NumPower(num, power);

        Console.WriteLine(result);
    }

    private static double NumPower(double num, int power)
    {
        double number = num;

        if (power > 0)
        {
            for (int i = 1; i < power; i++)
            {
                number *= num;
            }
        }
        else
        {
            number = 0;
        }

        return number;
    }
}
