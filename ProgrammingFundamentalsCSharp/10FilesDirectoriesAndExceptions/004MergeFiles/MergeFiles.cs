namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            string[] firstFile = File.ReadAllLines("FileOne.txt");
            string[] secondFile = File.ReadAllLines("FileTwo.txt");

            List<string> output = new List<string> { };

            int index = 0;

            while (index < Math.Max(firstFile.Length, secondFile.Length))
            {
                try
                {
                    output.Add(firstFile[index]);
                }
                catch { }

                try
                {
                    output.Add(secondFile[index]);
                }
                catch { }

                index++;
            }

            File.WriteAllText("Output.txt", string.Join($"{Environment.NewLine}", output));
        }
    }
}