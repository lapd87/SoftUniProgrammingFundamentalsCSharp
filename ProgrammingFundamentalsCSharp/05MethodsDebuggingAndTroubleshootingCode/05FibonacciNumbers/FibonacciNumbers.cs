using System;

internal class FibonacciNumbers
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int num = GetFibonacci(n);

        Console.WriteLine(num);
    }

    private static int GetFibonacci(int n)
    {
        int Fibonacci(int a, int b, int count, int number)
        {
            if (count < number)
            {
                return Fibonacci(b, a + b, count + 1, number);
            }
            else
            {
                return a + b;
            }
        }

        return Fibonacci(0, 1, 1, n);
    }
}