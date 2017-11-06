namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(^|\s)(?<!._-)(([a-zA-Z0-9][\w.-]+)@[a-zA-Z0-9][\w-_]+[a-zA-z0-9]\.[\w.-_]+[a-zA-Z0-9])(?!.-_)";

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m.Groups[2].Value);
            }
        }
    }
}