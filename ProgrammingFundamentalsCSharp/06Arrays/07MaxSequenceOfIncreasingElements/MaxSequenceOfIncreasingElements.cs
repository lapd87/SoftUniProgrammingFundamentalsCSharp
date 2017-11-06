using System;
using System.Linq;

class MaxSequenceOfIncreasingElements
{
    static void Main()
    {
        int[] inputArray = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        if (inputArray.Length < 1)
        {
            return;
        }
        else if (inputArray.Length == 1)
        {
            Console.WriteLine(inputArray[0]);
            return;
        }

        int length = 1;
        int maxLength = 1;
        int endIndex = 0;
        int maxEndIndex = 0;

        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            if (inputArray[i] < inputArray[i + 1])
            {
                length++;
                endIndex = i + 1;
            }
            else
            {
                if (length > maxLength)
                {
                    maxEndIndex = i;
                    maxLength = length;
                }

                length = 1;
            }
        }

        if (length > maxLength)
        {
            maxEndIndex = endIndex;
            maxLength = length;
        }

        for (int i = maxEndIndex - maxLength + 1; i <= maxEndIndex; i++)
        {
            Console.Write(inputArray[i] + " ");
        }

        Console.WriteLine();
    }
}
