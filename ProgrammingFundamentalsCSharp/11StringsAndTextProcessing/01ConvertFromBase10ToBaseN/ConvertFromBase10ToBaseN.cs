namespace ConvertFromBase10ToBaseN
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
            BigInteger number = BigInteger.Parse(input[1]);

            string output = "";
            BigInteger reminder = 0;

            while (number > 0)
            {
                reminder = number % numSystem;
                number /= numSystem;
                output = reminder.ToString() + output;
            }

            Console.WriteLine(output);
        }
    }
}