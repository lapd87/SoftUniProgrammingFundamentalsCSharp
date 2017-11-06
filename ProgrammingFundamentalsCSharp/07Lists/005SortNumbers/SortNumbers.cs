using System;
using System.Collections.Generic;
using System.Linq;

class SortNumbers
{
    static void Main()
    {
        List<decimal> input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToList();

        input.Sort();

        Console.WriteLine(string.Join(" <= ", input));
    }
}
