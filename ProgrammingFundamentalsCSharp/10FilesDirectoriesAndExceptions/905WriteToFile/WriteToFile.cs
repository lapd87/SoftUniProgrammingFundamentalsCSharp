namespace WriteToFile
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            char[] input = File.ReadAllText("sample_text.txt").ToCharArray();

            char[] punctuations = new char[] { '.', ',', '!', '?', ':' };

            List<char> output = new List<char> { };

            foreach (var ch in input)
            {
                if (!punctuations.Contains(ch))
                {
                    output.Add(ch);
                }
            }

            File.WriteAllText("output.txt", string.Join("", output));
        }
    }
}