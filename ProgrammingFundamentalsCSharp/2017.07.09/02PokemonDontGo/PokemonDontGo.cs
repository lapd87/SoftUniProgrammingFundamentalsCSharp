namespace PokemonDontGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> distances = Console.ReadLine()
                                .Trim()
                                .Split(new string[] { " " }, StringSplitOptions
                                .RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            int sum = 0;

            while (distances.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                int value;

                if (index < 0)
                {
                    index = 0;
                    value = distances[0];

                    distances[0] = distances[distances.Count - 1];
                }
                else if (index >= distances.Count)
                {
                    index = distances.Count - 1;
                    value = distances[distances.Count - 1];

                    distances[distances.Count - 1] = distances[0];
                }
                else
                {
                    value = distances[index];
                    distances.RemoveAt(index);
                }

                sum += value;

                for (int i = 0; i < distances.Count; i++)
                {
                    if (distances[i] <= value)
                    {
                        distances[i] += value;
                    }
                    else
                    {
                        distances[i] -= value;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}