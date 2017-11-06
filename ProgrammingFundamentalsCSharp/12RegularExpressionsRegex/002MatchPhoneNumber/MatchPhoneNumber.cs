namespace MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\+359(\s|-)2\1[0-9]{3}\1[0-9]{4}\b";

            string result = "";

            foreach (Match m in Regex.Matches(input, pattern))
            {
                result += m.Value + ", ";
            }

            Console.WriteLine(result.Trim(',', ' '));
        }
    }
}
