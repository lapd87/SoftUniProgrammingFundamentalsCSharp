namespace ExtractSentencesByKeyword
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string matchWord = Console.ReadLine();

            string[] input = Console.ReadLine()
                            .Split(new string[] { ".", "!", "?" }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();

            string pattern = "\\W(" + matchWord + ")\\W";

            foreach (var sentence in input)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
