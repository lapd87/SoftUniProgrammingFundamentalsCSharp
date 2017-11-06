namespace MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputFile = File.ReadAllLines("../../input.txt");

            int inputLine = 0;

            List<string> output = new List<string> { };

            while (inputLine < inputFile.Length)
            {
                int[] inputArray = inputFile[inputLine]
                                .Trim()
                                .Split(new string[] { " " }, StringSplitOptions
                                .RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

                if (inputArray.Length < 1)
                {
                    output.Add("");

                    inputLine++;

                    continue;
                }
                else if (inputArray.Length == 1)
                {
                    output.Add(inputArray[0].ToString());

                    inputLine++;

                    continue;
                }

                int count = 0;
                int maxCount = 0;
                int index = 0;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    for (int j = i; j < inputArray.Length; j++)
                    {
                        if (inputArray[i] == inputArray[j])
                        {
                            count++;
                        }
                    }

                    if (maxCount < count)
                    {
                        maxCount = count;
                        index = i;
                    }

                    count = 0;
                }

                output.Add(inputArray[index].ToString());

                inputLine++;
            }

            File.WriteAllText("../../output.txt", string.Join($"{Environment.NewLine}", output));
        }
    }
}