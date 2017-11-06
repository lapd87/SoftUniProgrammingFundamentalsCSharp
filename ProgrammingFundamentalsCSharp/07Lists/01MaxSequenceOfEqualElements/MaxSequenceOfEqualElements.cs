using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        List<int> input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int count = 1;
        int maxCount = 1;
        int index = 0;

        for (int i = 0; i < input.Count() - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }

            if (count > maxCount)
            {
                maxCount = count;
                index = i + 1;
            }
        }

        for (int i = index; i > index - maxCount; i--)
        {
            Console.Write(input[i] + " ");
        }

        Console.WriteLine();
    }
}
