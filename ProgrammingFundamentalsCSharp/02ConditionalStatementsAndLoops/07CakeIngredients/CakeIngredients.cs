using System;

class CakeIngredients
{
    static void Main()
    {
        string ingredient = Console.ReadLine();

        int count = 0;

        while (ingredient != "Bake!")
        {
            count++;
            Console.WriteLine($"Adding ingredient {ingredient}.");
            ingredient = Console.ReadLine();
        }

        Console.WriteLine($"Preparing cake with {count} ingredients.");
    }
}
