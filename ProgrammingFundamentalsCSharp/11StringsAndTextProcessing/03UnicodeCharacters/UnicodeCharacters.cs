namespace UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            Console.WriteLine((string.Join("", input.Select(ch => $@"\u{Convert.ToUInt16(ch):X4}").ToList())).ToLower());
        }
    }
}
