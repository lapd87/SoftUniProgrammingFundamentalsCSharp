﻿using System;
using System.Collections.Generic;
using System.Linq;

class PhonebookUpgrade
{
    static void Main()
    {
        string[] command = Console.ReadLine()
                          .Trim()
                          .Split(new string[] { " " }, StringSplitOptions
                          .RemoveEmptyEntries)
                          .ToArray();

        SortedDictionary<string, string> phonebook = new SortedDictionary<string, string> { };

        while (command[0] != "END")
        {
            switch (command[0])
            {
                case "A":
                    if (!phonebook.ContainsKey(command[1]))
                    {
                        phonebook.Add(command[1], command[2]);
                    }
                    else
                    {
                        phonebook[command[1]] = command[2];
                    }
                    break;

                case "S":
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                    break;

                case "ListAll":
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    break;
            }

            command = Console.ReadLine()
                     .Trim()
                     .Split(new string[] { " " }, StringSplitOptions
                     .RemoveEmptyEntries)
                     .ToArray();
        }
    }
}
