using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurrences
{
    static void Main()
    {
        List<string> input = Console.ReadLine()
           .ToLower()
           .Trim()
           .Split(new string[] { " " }, StringSplitOptions
           .RemoveEmptyEntries)
           .ToList();

        Dictionary<string, int> counts = new Dictionary<string, int> { };

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

        List<string> result = new List<string> { };

        foreach (var item in counts)
        {
            if (item.Value % 2 == 1)
            {
                result.Add(item.Key);
            }
        }

        Console.WriteLine(string.Join(", ", result));
    }
}
