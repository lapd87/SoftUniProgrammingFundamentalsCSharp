namespace task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0;

            List<string> sites = new List<string> { };

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                                .Trim()
                                .Split(new string[] { " " }, StringSplitOptions
                                .RemoveEmptyEntries)
                                .ToArray();

                string currentSite = data[0];

                totalLoss += ulong.Parse(data[1]) * decimal.Parse(data[2]);

                sites.Add(currentSite);
            }

            foreach (var item in sites)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, sites.Count)}");
        }
    }
}