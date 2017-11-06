namespace MagicExchangeableWords
{
    using System;
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

            string firstText = input[0];
            string secondText = input[1];

            Console.WriteLine(MagicExchangeableWords(firstText, secondText));
        }

        private static string MagicExchangeableWords(string firstText, string secondText)
        {
            bool isMagic = firstText.Distinct().ToArray().Length == secondText.Distinct().ToArray().Length;

            return isMagic.ToString().ToLower();
        }
    }
}