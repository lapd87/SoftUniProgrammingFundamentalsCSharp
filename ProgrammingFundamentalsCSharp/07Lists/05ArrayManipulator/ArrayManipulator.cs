using System;
using System.Collections.Generic;
using System.Linq;

internal class ArrayManipulator
{
    private static void Main()
    {
        List<short> input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(short.Parse)
            .ToList();

        string[] commands = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

        while (commands[0] != "print")
        {
            short commandsLength = (short)commands.Length;
            short indexOrElementOrPosition = 0;

            if (commandsLength > 1)
            {
                indexOrElementOrPosition = short.Parse(commands[1]);
            }

            switch (commands[0])
            {
                case "add":
                    input.Insert(indexOrElementOrPosition,
                                    short.Parse(commands[2]));
                    break;

                case "addMany":
                    input.InsertRange(indexOrElementOrPosition, commands
                         .Skip(2)
                         .Select(short.Parse)
                         .ToArray());
                    break;

                case "contains":
                    Console.WriteLine(input.IndexOf(indexOrElementOrPosition));
                    break;

                case "remove":
                    input.RemoveAt(indexOrElementOrPosition);
                    break;

                case "shift":
                    for (short i = 0; i < indexOrElementOrPosition % input.Count; i++)
                    {
                        input.Add(input[0]);
                        input.RemoveAt(0);
                    }
                    break;

                case "sumPairs":
                    for (short i = 0; i < input.Count - 1; i++)
                    {
                        input[i] += input[i + 1];
                        input.RemoveAt(i + 1);
                    }
                    break;
            }

            commands = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();
        }

        Console.WriteLine("[" + string.Join(", ", input) + "]");
    }
}