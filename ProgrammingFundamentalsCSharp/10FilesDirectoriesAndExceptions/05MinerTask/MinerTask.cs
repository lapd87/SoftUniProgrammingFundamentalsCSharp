namespace MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputFile = File.ReadAllLines("../../input.txt");

            int inputLine = 0;

            List<string> output = new List<string> { };

            while (inputLine < inputFile.Length)
            {
                Dictionary<string, long> totalResources = new Dictionary<string, long> { };

                string resource = inputFile[inputLine];

                inputLine++;

                while (resource != "stop")
                {
                    int quantity = int.Parse(inputFile[inputLine]);

                    inputLine++;

                    if (totalResources.ContainsKey(resource))
                    {
                        totalResources[resource] += quantity;
                    }
                    else
                    {
                        totalResources.Add(resource, quantity);
                    }

                    resource = inputFile[inputLine];

                    inputLine++;
                }

                foreach (var item in totalResources)
                {
                    output.Add($"{item.Key} -> {item.Value}");
                }
            }

            File.WriteAllText("../../output.txt", string.Join($"{Environment.NewLine}", output));
        }
    }
}