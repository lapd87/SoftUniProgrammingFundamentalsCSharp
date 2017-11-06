using System;
using System.Numerics;

class FactorialTrailingZeroes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int zeroes = FactorialZeroes(FactorialOfN(n));

        Console.WriteLine(zeroes);
    }

    private static int FactorialZeroes(BigInteger number)
    {
        int count = 0;

        string factorial = number.ToString();

        for (int i = factorial.Length - 1; i >= 0; i--)
        {
            if (factorial[i] == '0')
            {
                count++;
            }
            else
            {
                return count;
            }
        }

        return count;
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
