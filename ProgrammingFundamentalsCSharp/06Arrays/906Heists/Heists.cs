using System;
using System.Linq;

class Heists
{
    static void Main()
    {
        int[] pricesJewelsGold = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string[] commands = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries);

        double expenses = 0;
        long earningsSum = 0;

        while (commands[0] != "Jail" && commands[1] != "Time")
        {

            char[] loot = commands[0].ToCharArray();
            expenses += double.Parse(commands[1]);

            for (int i = 0; i < loot.Length; i++)
            {
                if (loot[i] == '%')
                {
                    earningsSum += pricesJewelsGold[0];
                }
                if (loot[i] == '$')
                {
                    earningsSum += pricesJewelsGold[1];
                }
            }

            commands = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries);
        }

        if (expenses > earningsSum)
        {
            Console.WriteLine($"Have to find another job. Lost: {expenses - earningsSum}.");

        }
        else
        {
            Console.WriteLine($"Heists will continue. Total earnings: {earningsSum - expenses}.");
        }

    }
}
