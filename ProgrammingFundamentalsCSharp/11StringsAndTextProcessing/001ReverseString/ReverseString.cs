namespace ReverseString
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            char[] output = input.Reverse().ToArray();

            Console.WriteLine(string.Join("", output));
        }
    }
}