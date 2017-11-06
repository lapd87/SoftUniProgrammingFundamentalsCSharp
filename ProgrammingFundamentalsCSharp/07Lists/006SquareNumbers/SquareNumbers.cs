using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        List<double> input = Console.ReadLine()
                        .Trim()
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToList();

        for (int i = 0; i < input.Count(); i++)
        {
            if (Math.Sqrt(input[i]) != (int)Math.Sqrt(input[i]))
            {
                input.RemoveAt(i);
                i--;
            }
        }

        input.Sort();
        input.Reverse();

        Console.WriteLine(string.Join(" ", input));
    }
}
