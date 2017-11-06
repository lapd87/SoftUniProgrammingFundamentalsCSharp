namespace Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (true)
            {
                string didimonPattern = @"[^a-zA-Z\-]+";

                Match didimon = Regex.Match(input, didimonPattern);

                if (!didimon.Success)
                {
                    break;
                }

                Console.WriteLine(didimon);

                int index = didimon.Index;

                input = input.Substring(index + didimon.Length, input.Length - index - didimon.Length);

                string bojomonPattern = @"([a-zA-Z]+\-[a-zA-Z]+)";

                Match bojomon = Regex.Match(input, bojomonPattern);

                if (!bojomon.Success)
                {
                    break;
                }

                Console.WriteLine(bojomon);

                index = bojomon.Index;

                input = input.Substring(index + bojomon.Length, input.Length - index - bojomon.Length);
            }
        }
    }
}