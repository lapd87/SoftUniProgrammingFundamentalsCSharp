namespace EqualSums
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
                    output.Add("0");

                    inputLine++;

                    continue;
                }

                int index = -1;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    int sumLeft = 0;
                    int sumRight = 0;

                    for (int j = 0; j < i; j++)
                    {
                        sumLeft += inputArray[j];
                    }

                    for (int j = inputArray.Length - 1; j > i; j--)
                    {
                        sumRight += inputArray[j];
                    }

                    if (sumLeft == sumRight)
                    {
                        index = i;
                        break;
                    }
                }

                if (index < 0)
                {
                    output.Add("no");
                }
                else
                {
                    output.Add(index.ToString());
                }

                inputLine++;
            }

            File.WriteAllText("../../output.txt", string.Join($"{Environment.NewLine}", output));
        }
    }
}