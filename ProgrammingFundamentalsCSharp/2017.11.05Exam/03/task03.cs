namespace task03
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] values = Console.ReadLine()
                            .Trim()
                            .Split(new string[] { "{", "}" }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();

            string pattern = @"([a-zA-Z]+)(.+)(\1)";

            Regex reg = new Regex(pattern);

            int index = 0;

            foreach (Match item in reg.Matches(input))
            {
                if (index < values.Length)
                {
                    string currentValue = values[index];

                    int startIndex = input.IndexOf(item.Groups[2].ToString());
                    int length = item.Groups[2].Length;

                    input = input.Remove(startIndex, length).Insert(startIndex, currentValue);
                }

                index++;
            }

            Console.WriteLine(input);
        }
    }
}