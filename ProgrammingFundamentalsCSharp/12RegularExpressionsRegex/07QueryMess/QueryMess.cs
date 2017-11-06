namespace QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string replaceWithSpace = @"(%20)|(\+)";

            string replaceMultipleSpace = @"(\s+)";

            string matchPairs = @"([^&|?]+)?(?==)=(.+?(?=&|\?|$))";

            while (input != "END")
            {
                input = Regex.Replace(input, replaceWithSpace, " ");
                input = Regex.Replace(input, replaceMultipleSpace, " ");

                Dictionary<string, List<string>> result = new Dictionary<string, List<string>> { };

                int count = Regex.Matches(input, matchPairs).Count;

                foreach (Match item in Regex.Matches(input, matchPairs))
                {
                    string key = Regex.Match(item.Value, @"(.+)=").Groups[1].Value.Trim();
                    string value = Regex.Match(item.Value, @"=(.+)").Groups[1].Value.Trim();

                    if (!result.ContainsKey(key))
                    {
                        result.Add(key, new List<string> { });
                    }

                    result[key].Add(value);
                }

                foreach (var item in result)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}