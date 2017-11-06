using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse
{
    static void Main()
    {
        List<int> input = Console.ReadLine()
            .Trim().Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x >= 0)
            .ToList();

        input.Reverse();

        if (input.Count() == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
