using System;
using System.Linq;

class EqualSums
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
            Console.WriteLine(0);
            return;
        }

        int index = -1;

        for (int i = 0; i < inputArray.Length; i++)
        {
            int sumLeft = 0;
            int sumRight = 0;

            for (int j = 0; j < i; j++)
            {
                sumLeft += inputArray[j];
            }

            for (int j = inputArray.Length - 1; j > i; j--)
            {
                sumRight += inputArray[j];
            }

            if (sumLeft == sumRight)
            {
                index = i;
                break;
            }
        }

        if (index < 0)
        {
            Console.WriteLine("no");
        }
        else
        {
            Console.WriteLine(index);
        }
    }
}
