using System;
using System.Linq;

class AppendLists
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Trim()
            .Split(new string[] { "|" }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();

        input.Reverse();

        var output = string.Join(" ", input)
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();

        Console.WriteLine(string.Join(" ", output));
    }
}
