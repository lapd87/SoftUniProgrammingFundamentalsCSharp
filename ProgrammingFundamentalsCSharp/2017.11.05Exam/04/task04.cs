namespace task04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> dataserver = new Dictionary<string, Dictionary<string, long>> { };

            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>> { };

            while (input != "thetinggoesskrra")
            {
                string[] inputArgs = input
                        .Trim()
                        .Split(new string[] { " -> ", " | " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

                if (inputArgs.Length == 1)
                {
                    string currentSet = inputArgs[0];

                    Dictionary<string, long> keySize = new Dictionary<string, long> { };

                    if (cache.ContainsKey(currentSet))
                    {
                        keySize = cache[currentSet];

                        cache.Remove(currentSet);
                    }

                    if (!dataserver.ContainsKey(currentSet))
                    {
                        dataserver.Add(currentSet, keySize);
                    }
                }
                else
                {
                    string currentSet = inputArgs[2];
                    string currentKey = inputArgs[0];
                    long currentSize = long.Parse(inputArgs[1]);

                    if (!dataserver.ContainsKey(currentSet))
                    {
                        if (!cache.ContainsKey(currentSet))
                        {
                            cache.Add(currentSet, new Dictionary<string, long> { });
                        }

                        cache[currentSet].Add(currentKey, currentSize);
                    }
                    else
                    {
                        if (!dataserver[currentSet].ContainsKey(currentKey))
                        {
                            dataserver[currentSet].Add(currentKey, 0);
                        }

                        dataserver[currentSet][currentKey] = currentSize;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var set in dataserver
                                .OrderByDescending(d => d.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {set.Key}, Total Size: {set.Value.Values.Sum()}");
                foreach (var key in set.Value)
                {
                    Console.WriteLine($"$.{key.Key}");
                }

                break;
            }
        }
    }
}