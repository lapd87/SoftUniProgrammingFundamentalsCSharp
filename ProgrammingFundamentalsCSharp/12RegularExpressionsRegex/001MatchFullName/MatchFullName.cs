namespace MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string result = "";

            foreach (Match m in Regex.Matches(input, pattern))
            {
                result += m.Value + " ";
            }

            Console.WriteLine(result.Trim());
        }
    }
}