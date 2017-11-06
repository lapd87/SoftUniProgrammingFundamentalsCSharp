namespace TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                    .Trim()
                    .Split(new string[] { " ", "," }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToArray();

            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
