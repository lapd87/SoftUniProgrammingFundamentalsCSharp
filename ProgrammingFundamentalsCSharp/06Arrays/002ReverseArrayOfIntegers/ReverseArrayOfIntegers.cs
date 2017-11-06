using System;

class ReverseArrayOfIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] intArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(intArray);

        foreach (var item in intArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
