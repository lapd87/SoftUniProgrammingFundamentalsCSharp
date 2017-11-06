namespace Censorship
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();

            sentence = Regex.Replace(sentence, "(" + word + ")", new string('*', word.Length));

            Console.WriteLine(sentence);
        }
    }
}