namespace PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Pokemon> pokemons = new List<Pokemon> { };

            while (input != "wubbalubbadubdub")
            {
                string[] inputArgs = input
                                    .Trim()
                                    .Split(new string[] { " -> " }, StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .ToArray();

                string currentName = inputArgs[0];

                if (inputArgs.Count() == 1)
                {
                    if (pokemons.Any(p => p.Name == currentName))
                    {
                        Pokemon calledPokemon = pokemons.FirstOrDefault(p => p.Name == currentName);

                        Console.WriteLine($"# {calledPokemon.Name}");

                        for (int i = 0; i < calledPokemon.EvolutionType.Count; i++)
                        {
                            Console.WriteLine($"{calledPokemon.EvolutionType[i]} <-> {calledPokemon.EvolutionIndex[i]}");
                        }
                    }
                }
                else
                {
                    if (!pokemons.Any(p => p.Name == currentName))
                    {
                        Pokemon currentPokemon = new Pokemon();

                        currentPokemon.Name = currentName;
                        currentPokemon.EvolutionType = new List<string> { };
                        currentPokemon.EvolutionIndex = new List<int> { };

                        pokemons.Add(currentPokemon);
                    }

                    int index = pokemons.IndexOf(pokemons.FirstOrDefault(p => p.Name == currentName));

                    pokemons[index].EvolutionType.Add(inputArgs[1]);
                    pokemons[index].EvolutionIndex.Add(int.Parse(inputArgs[2]));
                }

                input = Console.ReadLine();
            }

            foreach (var poke in pokemons)
            {
                var results = poke.EvolutionType.Zip(poke.EvolutionIndex, (a, b) => new
                {
                    type = a,
                    index = b
                })
                            .OrderByDescending(pair => pair.index);

                Console.WriteLine($"# {poke.Name}");

                foreach (var item in results)
                {
                    Console.WriteLine($"{item.type} <-> {item.index}");
                }
            }
        }
    }

    internal class Pokemon
    {
        public string Name { get; set; }
        public List<string> EvolutionType { get; set; }
        public List<int> EvolutionIndex { get; set; }
    }
}