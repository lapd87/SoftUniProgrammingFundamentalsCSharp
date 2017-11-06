using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(FactorialOfN(n));
    }

    private static BigInteger FactorialOfN(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        else
        {
            return n * FactorialOfN(n - 1);
        }
    }
}
