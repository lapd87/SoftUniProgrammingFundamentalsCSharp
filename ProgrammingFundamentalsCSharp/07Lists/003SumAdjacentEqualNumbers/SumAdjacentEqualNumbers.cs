using System;
using System.Collections.Generic;
using System.Linq;

class SumAdjacentEqualNumbers
{
    static void Main()
    {
        List<double> input = Console.ReadLine()
            .Trim().Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        int index = 0;

        while (index < input.Count() - 1)
        {
            if (input[index] == input[index + 1])
            {
                input[index] *= 2;
                input.RemoveAt(index + 1);
                index = 0;
            }
            else
            {
                index++;
            }
        }

        Console.WriteLine(string.Join(" ", input));
    }
}
