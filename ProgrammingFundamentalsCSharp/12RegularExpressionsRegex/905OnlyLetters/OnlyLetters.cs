namespace OnlyLetters
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

            int lastIndex = 0;

            string result = "";

            foreach (Match item in Regex.Matches(input, @"(\d+)[^0-9]"))
            {
                int index = item.Index;

                int count = item.Groups[1].Value.Length;

                char letter = input[index + count];

                result += input.Substring(lastIndex, index - lastIndex) + letter;

                lastIndex = index + count;
            }

            result += input.Substring(lastIndex, input.Length - lastIndex);

            Console.WriteLine(result);
        }
    }
}
