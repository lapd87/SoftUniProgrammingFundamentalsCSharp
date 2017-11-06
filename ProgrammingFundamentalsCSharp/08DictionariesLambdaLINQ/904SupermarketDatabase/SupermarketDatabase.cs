using System;
using System.Collections.Generic;
using System.Linq;

class SupermarketDatabase
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

        Dictionary<string, string> productPriceQuantity = new Dictionary<string, string> { };

        while (input[0] != "stocked")
        {
            string product = input[0];
            double price = double.Parse(input[1]);
            int quantity = int.Parse(input[2]);

            if (!productPriceQuantity.ContainsKey(product))
            {
                productPriceQuantity.Add(product, "0 0");
            }

            double[] priceQuantity = productPriceQuantity[product]
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();

            priceQuantity[0] = price;
            priceQuantity[1] += quantity;

            productPriceQuantity[product] = string.Join(" ", priceQuantity);

            input = Console.ReadLine()
                        .Trim()
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();
        }

        double total = 0;

        foreach (var item in productPriceQuantity)
        {
            double[] priceQuantity = item.Value
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();

            double itemTotal = priceQuantity[0] * priceQuantity[1];

            total += itemTotal;

            Console.WriteLine($"{item.Key}: ${priceQuantity[0]:f2} * {priceQuantity[1]} = ${itemTotal:f2}");
        }

        Console.WriteLine("------------------------------");
        Console.WriteLine($"Grand Total: ${total:f2}");
    }
}
