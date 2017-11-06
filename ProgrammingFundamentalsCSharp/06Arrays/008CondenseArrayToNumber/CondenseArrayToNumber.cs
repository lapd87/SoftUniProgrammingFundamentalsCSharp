using System;

class CondenseArrayToNumber
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine().Split(' ');

        int[] intArray = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            intArray[i] = int.Parse(inputArray[i]);
        }

        while (intArray.Length > 1)
        {
            int[] tempArray = new int[intArray.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = intArray[i] + intArray[i + 1];
            }

            intArray = tempArray.Clone() as int[];
        }

        Console.WriteLine(intArray[0]);
    }
}
