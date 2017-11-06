using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main()
    {
        List<int> input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int[] bomb = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int bombIndex = input.IndexOf(bomb[0]);

        while (bombIndex > -1)
        {
            int bombRange = 2 * bomb[1] + 1;

            int startIndex = bombIndex - bomb[1];

            while (startIndex < 0)
            {
                startIndex++;
                bombRange--;
            }

            while (startIndex + bombRange > input.Count)
            {
                bombRange--;
            }

            input.RemoveRange(startIndex, bombRange);

            bombIndex = input.IndexOf(bomb[0]);
        }

        int sum = 0;

        foreach (var item in input)
        {
            sum += item;
        }

        Console.WriteLine(sum);
    }
}
