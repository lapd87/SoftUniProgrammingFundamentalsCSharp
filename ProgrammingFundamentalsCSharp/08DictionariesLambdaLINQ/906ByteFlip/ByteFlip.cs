using System;
using System.Collections.Generic;
using System.Linq;

class ByteFlip
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

        List<string> result = new List<string> { };

        foreach (var item in input)
        {
            char[] byteArray = item.ToCharArray();

            if (byteArray.Length != 2)
            {
                continue;
            }

            string reversedByte = byteArray[1].ToString() + byteArray[0].ToString();

            result.Add(reversedByte);
        }

        result.Reverse();

        foreach (var item in result)
        {
            Console.Write((char)Convert.ToInt16(item, 16));
        }

        Console.WriteLine();
    }
}
