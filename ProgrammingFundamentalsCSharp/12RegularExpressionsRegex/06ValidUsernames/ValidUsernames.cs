namespace ValidUsernames
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
                            .Split(new string[] { " ", "(", ")", "\"", "\\", "/" }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();

            string pattern = @"\b([a-zA-Z][a-zA-Z0-9_]{2,24})\b";

            List<string> validUsernames = new List<string> { };

            foreach (var user in input)
            {
                if (Regex.IsMatch(user, pattern))
                {
                    validUsernames.Add(user);
                }
            }

            int maxLength = -1;
            int maxLengthIndex = -1;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                if (validUsernames[i].Length + validUsernames[i + 1].Length > maxLength)
                {
                    maxLength = validUsernames[i].Length + validUsernames[i + 1].Length;
                    maxLengthIndex = i;
                }
            }

            Console.WriteLine(validUsernames[maxLengthIndex]);
            Console.WriteLine(validUsernames[maxLengthIndex + 1]);
        }
    }
}
