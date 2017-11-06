using System;
using System.Collections.Generic;
using System.Linq;

class ImmuneSystem
{
    static void Main()
    {
        int initialHealth = int.Parse(Console.ReadLine());

        string virus = Console.ReadLine();

        List<string> virusesEncauntered = new List<string> { };

        int currentHealth = initialHealth;

        while (virus != "end")
        {
            int strength = virus.Sum(x => x) / 3;
            int defeatTime = virus.Length * strength;

            if (!virusesEncauntered.Contains(virus))
            {
                virusesEncauntered.Add(virus);
            }
            else
            {
                defeatTime /= 3;
            }

            Console.WriteLine($"Virus {virus}: {strength} => {defeatTime} seconds");

            currentHealth -= defeatTime;

            if (currentHealth > 0)
            {
                Console.WriteLine($"{virus} defeated in {defeatTime / 60}m {defeatTime - defeatTime / 60 * 60}s.");
                Console.WriteLine($"Remaining health: {currentHealth}");

                currentHealth += currentHealth * 2 / 10;

                if (currentHealth>initialHealth)
                {
                    currentHealth = initialHealth;
                }
            }
            else
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }

            virus = Console.ReadLine();
        }

        Console.WriteLine($"Final Health: {currentHealth}");
    }
}
