using System;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries);

        int[] topLeftArray = new int[inputArray.Length / 4];
        int[] bottomArray = new int[inputArray.Length / 2];
        int[] topRightArray = new int[inputArray.Length / 4];

        for (int i = 0; i < topLeftArray.Length; i++)
        {
            topLeftArray[i] = int.Parse(inputArray[i]);
            topRightArray[i] = int.Parse(inputArray[inputArray.Length - 1 - i]);
        }

        Array.Reverse(topLeftArray);

        int[] topArrray = topLeftArray.Concat(topRightArray).ToArray();

        int[] sumArray = new int[bottomArray.Length];

        for (int i = 0; i < sumArray.Length; i++)
        {
            bottomArray[i] = int.Parse(inputArray[inputArray.Length / 4 + i]);

            sumArray[i] = bottomArray[i] + topArrray[i];
        }

        foreach (var item in sumArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
