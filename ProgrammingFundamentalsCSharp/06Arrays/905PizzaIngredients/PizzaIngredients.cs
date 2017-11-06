using System;
using System.Linq;

class PizzaIngredients
{
    static void Main()
    {
        string[] ingredientArray = Console.ReadLine()
       .Trim()
       .Split(new string[] { " " }, StringSplitOptions
       .RemoveEmptyEntries)
       .ToArray();

        int ingredientLength = int.Parse(Console.ReadLine());

        int count = 0;
        int i = 0;

        string pizza = "";

        while (count < 10 && i < ingredientArray.Length)
        {
            if (ingredientArray[i].Length == ingredientLength)
            {
                Console.WriteLine($"Adding {ingredientArray[i]}.");
                pizza += ingredientArray[i] + " ";
                count++;
            }
            i++;
        }

        string[] pizzaArray = pizza
       .Trim()
       .Split(new string[] { " " }, StringSplitOptions
       .RemoveEmptyEntries)
       .ToArray();

        Console.WriteLine($"Made pizza with total of {count} ingredients.");
        Console.WriteLine($"The ingredients are: {string.Join(", ", pizzaArray)}.");
    }
}
