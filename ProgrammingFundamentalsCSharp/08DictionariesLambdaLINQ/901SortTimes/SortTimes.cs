using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class SortTimes
{
    static void Main()
    {
        List<string> input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();

        SortedDictionary<int,DateTime> result = new SortedDictionary<int,DateTime> { };

        for (int i = 0; i < input.Count; i++)
        {
            DateTime time =DateTime.ParseExact( input[i], "mm:ss", CultureInfo.InvariantCulture);
            result.Add(i, time);
        }

        input.Clear();

        foreach (var item in result.OrderBy(x=>x.Value))
        {
            input.Add(item.Value.ToString("mm:ss"));
        }

        Console.WriteLine(string.Join(", ",input));
    }
}
