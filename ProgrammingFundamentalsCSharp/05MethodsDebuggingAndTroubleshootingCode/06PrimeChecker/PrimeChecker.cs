using System;

class PrimeChecker
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(num));
    }

    private static bool IsPrime(long num)
    {
        long i = 2;

        if (num < i)
        {
            return false;
        }

        while (i <= Math.Sqrt(num))
        {
            if (num % i == 0)
            {
                return false;
            }
            i++;
        }

        return true;
    }
}
