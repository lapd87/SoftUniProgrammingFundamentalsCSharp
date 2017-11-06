namespace CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                        .Trim()
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            int skipM = input[0];
            int takeN = input[1];

            string text = Console.ReadLine();

            string pattern = @"\|<.{" + skipM + @"}(\w{0," + takeN + @"})";

            List<string> result = new List<string> { };

            foreach (Match m in Regex.Matches(text, pattern))
            {
                result.Add(m.Groups[1].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}