namespace MaxSequenceOfEqualElements
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
                string[] inputArray = inputFile[inputLine]
                                .Trim()
                                .Split(new string[] { " " }, StringSplitOptions
                                .RemoveEmptyEntries);

                if (inputArray.Length < 1)
                {
                    output.Add("");

                    inputLine++;

                    continue;
                }
                else if (inputArray.Length == 1)
                {
                    output.Add(inputArray[0]);

                    inputLine++;

                    continue;
                }

                int length = 1;
                int maxLength = 1;
                int endIndex = 0;
                int maxEndIndex = 0;

                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (inputArray[i] == inputArray[i + 1])
                    {
                        length++;
                        endIndex = i + 1;
                    }
                    else
                    {
                        if (length > maxLength)
                        {
                            maxEndIndex = i;
                            maxLength = length;
                        }

                        length = 1;
                    }
                }

                if (length > maxLength)
                {
                    maxEndIndex = endIndex;
                    maxLength = length;
                }

                string result = "";

                for (int i = maxEndIndex - maxLength + 1; i <= maxEndIndex; i++)
                {
                    result += inputArray[i] + " ";
                }

                output.Add(result);

                inputLine++;
            }

            File.WriteAllText("../../output.txt", string.Join($"{Environment.NewLine}", output));
        }
    }
}