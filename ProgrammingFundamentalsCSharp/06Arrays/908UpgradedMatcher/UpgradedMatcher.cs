using System;
using System.Linq;

internal class UpgradedMatcher
{
    private static void Main()
    {
        string[] productsArray = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries);

        long[] quantitiesArray = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

        decimal[] pricesArray = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

        string[] product = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries);


        while (product[0] != "done")
        {
            int index = Array.IndexOf(productsArray, product[0]);

            if (index > quantitiesArray.Length - 1 ||
                    quantitiesArray[index] < long.Parse(product[1]))
            {
                Console.WriteLine($"We do not have enough {productsArray[index]}");
            }
            else
            {
                Console.WriteLine($"{productsArray[index]} x {product[1]} costs {(pricesArray[index] * long.Parse(product[1])):f2}");

                quantitiesArray[index] -= long.Parse(product[1]);
            }

            product = Console.ReadLine()
                     .Trim()
                     .Split(new string[] { " " }, StringSplitOptions
                     .RemoveEmptyEntries);
        }
    }
}