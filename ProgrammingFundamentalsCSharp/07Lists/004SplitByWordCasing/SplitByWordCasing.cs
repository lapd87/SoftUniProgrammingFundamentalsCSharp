using System;
using System.Collections.Generic;
using System.Linq;

internal class SplitByWordCasing
{
    private static void Main()
    {
        List<string> input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " ", ",", ";", ":", ".", "!", "(", ")", "\"", "'", "\\", "/", "[", "]" }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();

        List<string> lowerCase = new List<string> { };
        List<string> upperCase = new List<string> { };
        List<string> mixCase = new List<string> { };

        foreach (var word in input)
        {
            char[] letterArray = word.ToCharArray();

            int lower = 0;
            int upper = 0;

            foreach (var letter in letterArray)
            {
                if (letter >= 'A' && letter <= 'Z')
                {
                    upper++;
                }
                else if (letter >= 'a' && letter <= 'z')
                {
                    lower++;
                }
                else
                {
                    lower = -1;
                    upper = -1;
                    break;
                }
            }

            if (lower == 0)
            {
                upperCase.Add(word);
            }
            else if (upper == 0)
            {
                lowerCase.Add(word);
            }
            else
            {
                mixCase.Add(word);
            }
        }

        Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
        Console.WriteLine("Mixed-case: " + string.Join(", ", mixCase));
        Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
    }
}