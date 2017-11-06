using System;
using System.Linq;

class ArrayStatistics
{
    static void Main()
    {
        int[] inputArray = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            min = Math.Min(min, inputArray[i]);
            max = Math.Max(max, inputArray[i]);
            sum += inputArray[i];
        }

        double average = sum / (double)inputArray.Length;

        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);
    }
}
