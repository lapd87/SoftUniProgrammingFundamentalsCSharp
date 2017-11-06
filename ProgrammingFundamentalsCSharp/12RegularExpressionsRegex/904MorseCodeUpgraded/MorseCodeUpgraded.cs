namespace MorseCodeUpgraded
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                            .Trim()
                            .Split(new string[] { "|" }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();

            string result = "";

            foreach (var item in input)
            {
                int totalSum = 0;
                int zeroCount = Regex.Matches(item, @"[0]").Count;
                int onesCount = Regex.Matches(item, @"[1]").Count;

                foreach (Match m0 in Regex.Matches(item, @"[0]+"))
                {
                    int length = m0.Value.Length;

                    if (length > 1)
                    {
                        totalSum += length;
                    }
                }

                foreach (Match m1 in Regex.Matches(item, @"[1]+"))
                {
                    int length = m1.Value.Length;

                    if (length > 1)
                    {
                        totalSum += length;
                    }
                }

                totalSum += zeroCount * 3 + onesCount * 5;

                result += (char)totalSum;
            }

            Console.WriteLine(result);
        }
    }
}
