using System;
using System.Collections.Generic;
using System.Linq;

class LegendaryFarming
{
    static void Main()
    {
        SortedDictionary<string, int> legendaryItems = new SortedDictionary<string, int> {
                                          {"fragments", 0},
                                          {"motes", 0} ,
                                          {"shards", 0}};

        SortedDictionary<string, int> junkItems = new SortedDictionary<string, int> { };

        bool itemFound = false;
        string legendary = "";

        while (!itemFound)
        {
            string[] materialQuantity = Console.ReadLine()
                .ToLower()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < materialQuantity.Length - 1; i += 2)
            {
                int quantity = int.Parse(materialQuantity[i]);
                string material = materialQuantity[i + 1];

                if (legendaryItems.ContainsKey(material))
                {
                    legendaryItems[material] += quantity;
                }
                else
                {
                    if (!junkItems.ContainsKey(material))
                    {
                        junkItems.Add(material, quantity);
                    }
                    else
                    {
                        junkItems[material] += quantity;
                    }
                }

                foreach (var item in legendaryItems)
                {
                    if (item.Value >= 250)
                    {
                        itemFound = true;

                        legendary = item.Key;

                        legendaryItems[item.Key] -= 250;

                        break;
                    }
                }

                if (itemFound)
                {
                    break;
                }

            }

            if (itemFound)
            {
                break;
            }
        }


        switch (legendary)
        {
            case "fragments": legendary = "Valanyr"; break;
            case "motes": legendary = "Dragonwrath"; break;
            case "shards": legendary = "Shadowmourne"; break;
        }

        Console.WriteLine($"{legendary} obtained!");

        foreach (var item in legendaryItems
                                .OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        foreach (var item in junkItems)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
