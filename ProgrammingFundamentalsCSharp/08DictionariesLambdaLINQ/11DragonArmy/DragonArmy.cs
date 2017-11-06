using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, SortedDictionary<string, string>> typeNameStats = new Dictionary<string, SortedDictionary<string, string>> { };

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                        .Trim()
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

            string type = input[0];
            string name = input[1];

            if (input[2] == "null") input[2] = "45";
            if (input[3] == "null") input[3] = "250";
            if (input[4] == "null") input[4] = "10";

            string stats = string.Join(" ", input.Skip(2));

            if (!typeNameStats.ContainsKey(type))
            {
                typeNameStats.Add(type, new SortedDictionary<string, string> { });
            }

            if (!typeNameStats[type].ContainsKey(name))
            {
                typeNameStats[type].Add(name, stats);
            }

            typeNameStats[type][name] = stats;
        }

        foreach (var type in typeNameStats)
        {
            double damageAVG = 0;
            double healthAVG = 0;
            double armorAVG = 0;

            int totalDamage = 0;
            int totalHealth = 0;
            int totalArmor = 0;

            double count = 0;

            foreach (var dragon in type.Value)
            {
                int[] damageHealthArmor = dragon.Value
                        .Trim()
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                totalDamage += damageHealthArmor[0];
                totalHealth += damageHealthArmor[1];
                totalArmor += damageHealthArmor[2];
                count++;
            }

            damageAVG = totalDamage / count;
            healthAVG = totalHealth / count;
            armorAVG = totalArmor / count;


            Console.WriteLine($"{type.Key}::({damageAVG:f2}/{healthAVG:f2}/{armorAVG:f2})");

            foreach (var dragon in type.Value)
            {
                int[] damageHealthArmor = dragon.Value
                        .Trim()
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                int damage = damageHealthArmor[0];
                int health = damageHealthArmor[1];
                int armor = damageHealthArmor[2];

                Console.WriteLine($"-{dragon.Key} -> damage: {damage}, health: {health}, armor: {armor}");
            }
        }
    }
}

