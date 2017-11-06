namespace Palindromes
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
                        .Split(new string[] { " ", ".", ",", "!", "?" }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

            List<string> output = new List<string> { };

            foreach (var word in input)
            {
                bool isPalindrome = true;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    output.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", output.Distinct().OrderBy(l => l)));
        }
    }
}