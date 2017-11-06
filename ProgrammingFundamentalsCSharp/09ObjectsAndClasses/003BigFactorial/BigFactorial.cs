using System;
using System.Numerics;

internal class BigFactorial
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger num = 1;

        for (int i = 2; i <= n; i++)
        {
            num *= i;
        }

        Console.WriteLine(num);
    }
}