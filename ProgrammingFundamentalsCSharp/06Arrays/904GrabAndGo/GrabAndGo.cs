using System;
using System.Linq;

class GrabAndGo
{
    static void Main()
    {
        int[] inputArray = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int num = int.Parse(Console.ReadLine());

        if (inputArray.Contains(num))
        {
            long sum = 0;
            int index = -1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == num)
                {
                    index = i;
                }
            }

            for (int i = 0; i < index; i++)
            {
                sum += inputArray[i];
            }

            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("No occurrences were found!");
        }
    }
}
