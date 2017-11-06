using System;

class LargestCommonEnd
{
    static void Main()
    {
        string[] inputArray1 = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries);
        string[] inputArray2 = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries);

        int minArrayLegth = Math.Min(inputArray1.Length, inputArray2.Length);

        int leftCount = 0;
        int rightCount = 0;

        while (leftCount < minArrayLegth &&
                inputArray1[leftCount] == inputArray2[leftCount])
        {
            leftCount++;
        }

        while (rightCount < minArrayLegth &&
                inputArray1[inputArray1.Length - rightCount - 1] ==
                inputArray2[inputArray2.Length - rightCount - 1])
        {
            rightCount++;
        }

        Console.WriteLine(Math.Max(leftCount, rightCount));
    }
}

