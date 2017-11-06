using System;

class SumArrays
{
    static void Main()
    {
        string[] inputArray1 = Console.ReadLine().Split(' ');
        string[] inputArray2 = Console.ReadLine().Split(' ');

        int newArrayLength = Math.Max(inputArray1.Length, inputArray2.Length);

        for (int i = 0; i < newArrayLength; i++)
        {
            Console.Write(int.Parse(inputArray1[i % inputArray1.Length]) +
                          int.Parse(inputArray2[i % inputArray2.Length]) + " ");
        }

        Console.WriteLine();
    }
}
