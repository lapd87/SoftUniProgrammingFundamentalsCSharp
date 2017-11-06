using System;
using System.Collections.Generic;
using System.Linq;

internal class CountNumbers
{
    private static void Main()
    {
        List<int> input = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

        input.Sort();

        var sorted = input.GroupBy(i => i);

        foreach (var item in sorted)
        {
            Console.WriteLine($"{item.Key} -> {item.Count()}");
        }
    }
}