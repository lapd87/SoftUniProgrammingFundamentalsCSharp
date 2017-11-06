using System;
using System.Linq;

internal class ManipulateArray
{
    private static void Main()
    {
        string[] inputArray = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();
        int commandCount = int.Parse(Console.ReadLine());

        string[] tempArray = inputArray.Clone() as string[];
        
        for (int i = 0; i < commandCount; i++)
        {
            string[] command = Console.ReadLine().Trim().Split();

            switch (command[0])
            {
                case "Reverse":
                    Array.Reverse(tempArray);
                    break;

                case "Distinct":
                    tempArray = tempArray.Distinct().ToArray();
                    break;

                case "Replace":
                    tempArray[int.Parse(command[1].ToString())] = command[2].ToString();
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", tempArray));
    }
}