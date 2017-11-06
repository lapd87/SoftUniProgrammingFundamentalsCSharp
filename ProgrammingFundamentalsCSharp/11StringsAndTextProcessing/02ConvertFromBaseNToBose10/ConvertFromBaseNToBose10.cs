namespace ConvertFromBaseNToBose10
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();

            int numSystem = int.Parse(input[0]);
            char[] number = input[1].ToCharArray();

            BigInteger result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = number[number.Length - 1 - i] - 48;
                result += currentDigit * BigInteger.Pow(numSystem, i);
            }

            Console.WriteLine(result);
        }
    }
}