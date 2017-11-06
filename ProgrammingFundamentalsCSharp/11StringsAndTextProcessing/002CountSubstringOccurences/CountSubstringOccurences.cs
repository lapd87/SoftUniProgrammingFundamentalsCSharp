namespace CountSubstringOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string inputText = Console.ReadLine().ToLower();
            string inputSubstring = Console.ReadLine().ToLower();

            int count = 0;

            for (int i = 0; i <= inputText.Length-inputSubstring.Length; i++)
            {
                if (inputText.Substring(i,inputSubstring.Length)==inputSubstring)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
