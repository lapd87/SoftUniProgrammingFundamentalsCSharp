using System;
using System.Collections.Generic;
using System.Linq;

internal class RandomizeWords
{
    private static void Main()
    {
        List<string> input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();

        Random rnd = new Random();

        for (int i = 0; i < input.Count; i++)
        {
            int rndNum = rnd.Next(input.Count);

            string temp = input[i];

            input[i] = input[rndNum];

            input[rndNum] = temp;
        }

        Console.WriteLine(string.Join(Environment.NewLine, input));
    }
}