using System;

class SumOfOddNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= 2 * n; i += 2)
        {
            Console.WriteLine(i);
            sum += i;
        }
        Console.WriteLine("Sum: " + sum);
    }
}
