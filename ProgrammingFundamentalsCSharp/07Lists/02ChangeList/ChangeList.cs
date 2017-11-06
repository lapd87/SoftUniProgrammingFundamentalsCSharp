using System;
using System.Collections.Generic;
using System.Linq;

class ChangeList
{
    static void Main()
    {
        List<int> input = Console.ReadLine()
                    .Trim()
                    .Split(new string[] { " " }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

        string[] command = Console.ReadLine()
                    .Trim()
                    .Split(new string[] { " " }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToArray();

        while (command[0] != "Odd" && command[0] != "Even")
        {
            if (command[0] == "Delete")
            {
                for (int i = 0; i < input.Count(); i++)
                {
                    if (input[i] == int.Parse(command[1]))
                    {
                        input.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (command[0] == "Insert")
            {
                input.Insert(int.Parse(command[2]), int.Parse(command[1]));
            }

            command = Console.ReadLine()
                   .Trim()
                   .Split(new string[] { " " }, StringSplitOptions
                   .RemoveEmptyEntries)
                   .ToArray();
        }

        for (int i = 0; i < input.Count(); i++)
        {
            if (command[0] == "Even" && input[i] % 2 == 0)
            {
                Console.Write(input[i] + " ");
            }
            else if (command[0] == "Odd" && input[i] % 2 == 1)
            {
                Console.Write(input[i] + " ");
            }
        }

        Console.WriteLine();
    }
}
