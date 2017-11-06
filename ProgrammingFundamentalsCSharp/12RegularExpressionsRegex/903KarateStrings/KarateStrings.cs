namespace KarateStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(>)([\d])";

            int strengthLeft = 0;

            List<int> indexRemove = new List<int> { };

            foreach (Match item in Regex.Matches(input, pattern))
            {
                int index = item.Index;

                char nextChar = input[index + 1];

                int currentStrength = int.Parse(nextChar.ToString()) + strengthLeft;


                while (nextChar != '>' && currentStrength > 0)
                {
                    indexRemove.Add(index + 1);
                    currentStrength--;
                    index++;

                    if (input.Length - 1 < index + 1)
                    {
                        break;
                    }

                    nextChar = input[index + 1];
                }

                strengthLeft = currentStrength;
            }

            indexRemove.Reverse();

            foreach (var item in indexRemove)
            {
                if (item < input.Length)
                {
                    input = input.Remove(item, 1);
                }
            }

            Console.WriteLine(input);
        }
    }
}