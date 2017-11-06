using System;
using System.Linq;

class PairsByDifference
{
    static void Main()
    {
        int[] inputArray = Console.ReadLine()
          .Trim()
          .Split(new string[] { " " }, StringSplitOptions
          .RemoveEmptyEntries)
          .Select(int.Parse)
          .ToArray();
        int difference = int.Parse(Console.ReadLine());

        if (inputArray.Length < 2)
        {
            return;
        }


        int count = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = i; j < inputArray.Length; j++)
            {
                if (Math.Abs(inputArray[i] - inputArray[j]) == difference)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}
