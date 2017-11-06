namespace IndexOfLetters
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
                char[] inputArray = inputFile[inputLine].ToCharArray();

                for (int i = 0; i < inputArray.Length; i++)
                {
                    output.Add(inputArray[i] + " -> "
                                        + (int)(inputArray[i] - 97));
                }

                inputLine++;
            }

            File.WriteAllText("../../output.txt", string.Join($"{Environment.NewLine}", output));
        }
    }
}