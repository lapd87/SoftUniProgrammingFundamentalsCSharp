using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Trim()
            .Split(new string[] { "|" }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

        Dictionary<string, Dictionary<string, long>> countryCityPopulation = new Dictionary<string, Dictionary<string, long>> { };

        while (input[0] != "report")
        {
            string city = input[0];
            string country = input[1];
            long population = long.Parse(input[2]);

            if (!countryCityPopulation.ContainsKey(country))
            {
                countryCityPopulation.Add(country, new Dictionary<string, long> { });
            }

            if (!countryCityPopulation[country].ContainsKey(city))
            {
                countryCityPopulation[country].Add(city, 0);
            }

            countryCityPopulation[country][city] = population;

            input = Console.ReadLine()
                .Trim()
                .Split(new string[] { "|" }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();
        }

        foreach (var country in countryCityPopulation
                           .OrderByDescending(x => x.Value.Values.Sum()))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

            foreach (var city in country.Value
                                     .OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}
