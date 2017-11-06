using System;
using System.Collections.Generic;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " ", ".", ",", ":", ";", "!", "?", "(", ")", "[", "]", "'", "\"", "\\", "/" }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int k = input.Length / 4;

        var sum = input
                .Take(k)
                .Reverse()
            .Concat(input
                .Reverse()
                .Take(k))
                .ToArray()
            .Select((x, index) => x + input
                                        .Skip(k)
                                        .Take(2 * k)
                                        .ToArray()[index]);

        Console.WriteLine(string.Join(" ", sum));
    }
}
