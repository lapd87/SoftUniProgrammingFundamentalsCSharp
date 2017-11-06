using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main()
    {
        List<double> input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        SortedDictionary<double, int> counts = new SortedDictionary<double, int> { };

        for (int i = 0; i < input.Count; i++)
        {
            if (counts.ContainsKey(input[i]))
            {
                counts[input[i]]++;
            }
            else
            {
                counts.Add(input[i], 1);
            }
        }

        foreach (var item in counts)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}
