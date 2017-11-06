using System;
using System.Collections.Generic;
using System.Linq;

class Largest3Numbers
{
    static void Main()
    {
        List<double> input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        Console.WriteLine(string.Join(" ", input
                                    .OrderByDescending(x => x)
                                    .Take(3)));
    }
}
