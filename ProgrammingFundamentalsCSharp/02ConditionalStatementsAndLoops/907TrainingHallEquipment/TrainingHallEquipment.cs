using System;

class TrainingHallEquipment
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int items = int.Parse(Console.ReadLine());

        double subtotal = 0;

        for (int i = 1; i <= items; i++)
        {
            string itemName = Console.ReadLine();
            double itemPrice = double.Parse(Console.ReadLine());
            int itemCount = int.Parse(Console.ReadLine());

            if (itemCount > 1)
            {
                itemName += "s";
            }

            subtotal += itemPrice * itemCount;

            Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
        }

        Console.WriteLine($"Subtotal: ${subtotal:f2}");

        if (subtotal <= budget)
        {
            Console.WriteLine($"Money left: ${(budget - subtotal):f2}");
        }
        else
        {
            Console.WriteLine($"Not enough. We need ${(subtotal - budget):f2} more.");
        }
    }
}
