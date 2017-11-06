using System;
using System.Collections.Generic;
using System.Linq;

class SumReversedNumbers
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();

        Array.Reverse(input);

        string reversedInput = new string(input);

        int[] reversedArray = reversedInput.Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int sum = 0;

        foreach (var item in reversedArray)
        {
            sum += item;
        }

        Console.WriteLine(sum);
    }
}
