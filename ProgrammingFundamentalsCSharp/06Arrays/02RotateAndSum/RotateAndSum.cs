using System;
using System.Linq;

class RotateAndSum
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries);

        int kRightRotations = int.Parse(Console.ReadLine());

        int[] sumArray = new int[inputArray.Length];

        while (kRightRotations > 0)
        {
            int[] tempArray = new int[inputArray.Length];

            tempArray[0] = int.Parse(inputArray[inputArray.Length - 1]);
            sumArray[0] += tempArray[0];


            for (int i = 1; i < inputArray.Length; i++)
            {
                tempArray[i] = int.Parse(inputArray[i - 1]);
                sumArray[i] += tempArray[i];
            }

            inputArray = tempArray.Select(x => x.ToString()).ToArray();

            kRightRotations--;
        }

        foreach (var item in sumArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
