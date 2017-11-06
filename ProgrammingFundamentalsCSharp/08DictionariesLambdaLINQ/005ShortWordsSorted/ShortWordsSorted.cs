using System;
using System.Collections.Generic;
using System.Linq;

class ShortWordsSorted
{
    static void Main()
    {
        List<string> text = Console.ReadLine()
            .ToLower()
            .Trim()
            .Split(new string[] { " ", ".", ",", ":", ";", "!", "?", "(", ")", "[", "]", "'", "\"", "\\", "/" }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();

        Console.WriteLine(string.Join(", ", text
                                       .Where(x => x.Length < 5)
                                       .OrderBy(x => x)
                                       .Distinct()));

    }
}
