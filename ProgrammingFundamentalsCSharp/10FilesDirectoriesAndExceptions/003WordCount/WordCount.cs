namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, int> words = File.ReadAllText("words.txt")
            .Trim()
            .ToLower()
            .Split(new string[] { " ", ".", ",", "…", ":", ";", "!", "?", "(", ")", "[", "]", "{", "}", "<", ">", "'", "\"", "\\", "/", "|", "-", "_", "@", "#", "$", "%", "^", "&", "*", "`", "~", "№", $"{Environment.NewLine}" }, StringSplitOptions
            .RemoveEmptyEntries)
            .Distinct()
            .ToDictionary(kv => kv, kv => 0);

            string[] texts = File.ReadAllText("text.txt")
            .Trim()
            .ToLower()
            .Split(new string[] { " ", ".", ",", "…", ":", ";", "!", "?", "(", ")", "[", "]", "{", "}", "<", ">", "'", "\"", "\\", "/", "|", "-", "_", "@", "#", "$", "%", "^", "&", "*", "`", "~", "№", $"{Environment.NewLine}" }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

            foreach (var text in texts)
            {
                if (words.ContainsKey(text))
                {
                    words[text] += 1;
                }
            }

            File.WriteAllText("output.txt", string
                                .Join($"{Environment.NewLine}", words
                                    .OrderByDescending(v => v.Value)
                                    .Select(kv => kv.Key + " - " + kv.Value)));
        }
    }
}