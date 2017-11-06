namespace SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> townSales = new SortedDictionary<string, decimal> { };

            for (int i = 0; i < n; i++)
            {
                Sale nextSale = ReadSale();

                if (!townSales.ContainsKey(nextSale.Town))
                {
                    townSales.Add(nextSale.Town, 0);
                }

                townSales[nextSale.Town] += nextSale.Price * nextSale.Quantity;
            }

            PrintSales(townSales);
        }

        private static void PrintSales(SortedDictionary<string, decimal> townSales)
        {
            foreach (var item in townSales)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }

        private static Sale ReadSale()
        {
            string[] input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

            Sale nextSale = new Sale();
            nextSale.Town = input[0];
            nextSale.Price = decimal.Parse(input[2]);
            nextSale.Quantity = decimal.Parse(input[3]);

            return nextSale;
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}