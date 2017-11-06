using System;

class ReverseArrayOfStrings
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine().Split(' ');

        Array.Reverse(inputArray);

        foreach (var item in inputArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
