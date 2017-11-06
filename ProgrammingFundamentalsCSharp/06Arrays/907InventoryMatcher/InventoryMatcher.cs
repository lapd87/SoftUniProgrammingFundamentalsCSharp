using System;

class InventoryMatcher
{
    static void Main()
    {
        string[] productsArray = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries);

        string[] quantitiesArray = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries);

        string[] pricesArray = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries);

        string product = Console.ReadLine();

        while (product != "done")
        {
            int index = Array.IndexOf(productsArray, product);

            Console.WriteLine($"{productsArray[index]} costs: {pricesArray[index]}; Available quantity: {quantitiesArray[index]}");

            product = Console.ReadLine();
        }
    }
}
