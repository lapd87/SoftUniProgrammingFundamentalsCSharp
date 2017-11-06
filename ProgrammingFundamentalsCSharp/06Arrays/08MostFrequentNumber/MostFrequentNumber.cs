using System;
using System.Linq;

class MostFrequentNumber
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

        int count = 0;
        int maxCount = 0;
        int index = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = i; j < inputArray.Length; j++)
            {
                if (inputArray[i] == inputArray[j])
                {
                    count++;
                }
            }

            if (maxCount < count)
            {
                maxCount = count;
                index = i;
            }

            count = 0;
        }

        Console.WriteLine(inputArray[index]);
    }
}
