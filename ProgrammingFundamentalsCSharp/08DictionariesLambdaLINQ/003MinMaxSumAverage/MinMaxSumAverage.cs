using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] input = new int[n];

        for (int i = 0; i < n; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Sum = {input.Sum()}");
        Console.WriteLine($"Min = {input.Min()}");
        Console.WriteLine($"Max = {input.Max()}");
        Console.WriteLine($"Average = {input.Average()}");
    }
}
