namespace CharacterMultiplier
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
                            .Split(new string[] { " " }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();

            char[] firstWord = input[0].ToCharArray();
            char[] secondWord = input[1].ToCharArray();

            Console.WriteLine(CharacterMultiplier(firstWord, secondWord));
        }

        private static int CharacterMultiplier(char[] firstWord, char[] secondWord)
        {
            int result = 0;

            for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                result += firstWord[i] * secondWord[i];
            }

            if (firstWord.Length < secondWord.Length)
            {
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    result += secondWord[i];
                }
            }
            else if (firstWord.Length > secondWord.Length)
            {
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    result += firstWord[i];
                }
            }

            return result;
        }
    }
}
