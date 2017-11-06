using System;
using System.Collections.Generic;
using System.Linq;

class TakeSkipRope
{
    static void Main()
    {
        List<char> message = Console.ReadLine().ToList();

        List<byte> digits = new List<byte> { };

        List<char> text = new List<char> { };

        foreach (var item in message)
        {
            if (item >= 48 && item <= 57)
            {
                digits.Add(byte.Parse(item.ToString()));
            }
            else
            {
                text.Add(item);
            }
        }

        List<char> result = new List<char> { };

        int skip = 0;

        for (int i = 0; i < digits.Count - 1; i += 2)
        {
            byte take = digits[i];

            result.AddRange(text.Skip(skip).Take(take));

            skip += digits[i + 1] + take;
        }

        Console.WriteLine(string.Join("", result)); ;
    }
}
