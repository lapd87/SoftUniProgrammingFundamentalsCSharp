using System;
using System.Collections.Generic;
using System.Linq;

class OddFilter
{
    static void Main()
    {
        int[] input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        List<int> evenNums = new List<int> { };

        foreach (var item in input)
        {
            if (item%2==0)
            {
                evenNums.Add(item);
            }
        }

        double avg = evenNums.Average();

        List<int> oddNums = new List<int> { };

        foreach (var item in evenNums)
        {
            if (item>avg)
            {
                oddNums.Add(item + 1);
            }
            else
            {
                oddNums.Add(item - 1);
            }
        }

        Console.WriteLine(string.Join(" ", oddNums));
    }
}
