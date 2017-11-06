namespace LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                            .Trim()
                            .Split(new string[] { " ", "\t" }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();

            double totalSum = 0;

            foreach (var word in input)
            {
                double firstLetter = word[0];
                double lastLetter = word[word.Length - 1];

                string numString = string.Join("", word.Skip(1).Take(word.Length - 2).ToArray());
                int num = int.Parse(numString);

                double tempSum = num;

                if (firstLetter > 64 && firstLetter < 91)
                {
                    tempSum /= firstLetter - 64;
                }
                else if (firstLetter > 96 && firstLetter < 123)
                {
                    tempSum *= firstLetter - 96;
                }

                if (lastLetter > 64 && lastLetter < 91)
                {
                    tempSum -= lastLetter - 64;
                }
                else if (lastLetter > 96 && lastLetter < 123)
                {
                    tempSum += lastLetter - 96;
                }

                totalSum += tempSum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
