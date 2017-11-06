namespace MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(<(\w+))( ?href=.+)(>)(.+)(<\/?\2>)";

            while (input != "end")
            {

                input = Regex.Replace(input, pattern, m => "[URL" + m.Groups[3] + "]" + m.Groups[5] + "[/URL]");

                Console.WriteLine(input);

                input = Console.ReadLine();
            }
        }
    }
}