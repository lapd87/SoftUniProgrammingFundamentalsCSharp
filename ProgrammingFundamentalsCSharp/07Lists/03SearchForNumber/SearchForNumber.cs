using System;
using System.Collections.Generic;
using System.Linq;

class SearchForNumber
{
    static void Main()
    {
        List<int> input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int[] command = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        bool isNum = false;

        for (int i = command[1]; i < input.Count(); i++)
        {
            if (input[i] == command[2])
            {
                isNum = true;
            }
        }

        if (isNum)
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}
