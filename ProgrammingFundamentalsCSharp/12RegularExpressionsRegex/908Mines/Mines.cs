namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @".*?(<..>).*?";

            List<int> minesIndexes = new List<int> { };

            foreach (Match item in Regex.Matches(input, pattern))
            {
                string mine = item.Groups[1].Value;

                int blastRadius = Math.Abs(mine[1] - mine[2]);

                int index = input.IndexOf(mine);

                for (int i = index - blastRadius; i < index + 4 + blastRadius; i++)
                {
                    minesIndexes.Add(i);
                }
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (minesIndexes.Contains(i))
                {
                    result.Append("_");
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
