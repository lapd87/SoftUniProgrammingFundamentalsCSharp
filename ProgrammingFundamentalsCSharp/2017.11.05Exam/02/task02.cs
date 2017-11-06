namespace task02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                    .Trim()
                    .Split(new string[] { " " }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] commandArgs = command
                                    .Trim()
                                    .Split(new string[] { " " }, StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .ToArray();

                if (commandArgs[0] == "merge")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (startIndex >= input.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }

                    string toMerge = "";

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        toMerge += input[i];
                    }

                    for (int i = endIndex; i >= startIndex; i--)
                    {
                        input.RemoveAt(i);
                    }

                    input.Insert(startIndex, toMerge);
                }
                else
                {
                    int index = int.Parse(commandArgs[1]);
                    int partitions = int.Parse(commandArgs[2]);

                    if (partitions == 0 || partitions == 1)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    char[] toDivide = input[index].ToCharArray();

                    int equalPartitionsLength = toDivide.Length / partitions;

                    int lastPartitionLength = toDivide.Length - equalPartitionsLength * (partitions - 1);

                    if (equalPartitionsLength > lastPartitionLength)
                    {
                        equalPartitionsLength--;
                        lastPartitionLength = toDivide.Length - equalPartitionsLength * (partitions - 1);
                    }

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string substring = string.Join("", toDivide
                                    .Skip(i * equalPartitionsLength)
                                    .Take(equalPartitionsLength)
                                    .ToArray());

                        input.Insert(index + i, substring);
                    }

                    string lastString = string.Join("", toDivide
                                    .Skip((partitions - 1) * equalPartitionsLength)
                                    .Take(lastPartitionLength)
                                    .ToArray());

                    input.Insert(index + partitions - 1, lastString);
                    input.RemoveAt(index + partitions);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}