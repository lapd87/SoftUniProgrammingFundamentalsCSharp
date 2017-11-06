namespace UseYourChainsBuddy
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            string input = Console.ReadLine();

            string pattern = @"<p>(.*?)<\/p>";

            string manual = "";

            foreach (Match item in Regex.Matches(input, pattern))
            {
                string text = item.Groups[1].Value;

                string replaceWithSpace = @"[^a-z0-9]+";
                string replaceMultipleSpace = @"(\s{2,})";

                text = Regex.Replace(text, replaceWithSpace, " ");
                text = Regex.Replace(text, replaceMultipleSpace, " ");

                string decryptedText = "";

                foreach (char letter in text.ToCharArray())
                {
                    decryptedText += Decrypt(letter);
                }

                manual += decryptedText;
            }

            Console.WriteLine(manual);
        }

        private static char Decrypt(char letter)
        {
            if (letter < 'a' || letter > 'z')
            {
                return letter;
            }
            else
            {
                if (letter < 'n')
                {
                    return (char)(letter + 13);
                }
                else
                {
                    return (char)(letter - 13);
                }
            }
        }
    }
}