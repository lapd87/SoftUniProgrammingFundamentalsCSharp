using System;

class FastPrimeChecker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int num = 2; num <= n; num++)
        {
            bool isPrime = true;
            for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
            {
                if (num % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{num} -> {isPrime}");
        }
    }
}
