using System;

internal class CompareCharArrays
{
    private static void Main()
    {
        string[] firstArray = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        string[] secondArray = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        int minArrayLength = Math.Min(firstArray.Length, secondArray.Length);

        for (int i = 0; i < minArrayLength; i++)
        {
            if (char.Parse(firstArray[i]) > char.Parse(secondArray[i]))
            {
                PrintArray(secondArray);
                PrintArray(firstArray);
                return;
            }
            else if (char.Parse(firstArray[i]) < char.Parse(secondArray[i]))
            {
                PrintArray(firstArray);
                PrintArray(secondArray);
                return;
            }
        }

        if (firstArray.Length >= secondArray.Length)
        {
            PrintArray(secondArray);
            PrintArray(firstArray);
        }
        else
        {
            PrintArray(firstArray);
            PrintArray(secondArray);
        }
    }

    private static void PrintArray(string[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}