using System;
using System.Collections.Generic;
using System.Linq;

class MinerTask
{
    static void Main()
    {
        Dictionary<string, long> totalResources = new Dictionary<string, long> { };

        string resource = Console.ReadLine();

        while (resource != "stop")
        {
            int quantity = int.Parse(Console.ReadLine());

            if (totalResources.ContainsKey(resource))
            {
                totalResources[resource] += quantity;
            }
            else
            {
                totalResources.Add(resource, quantity);
            }

            resource = Console.ReadLine();
        }

        foreach (var item in totalResources)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
