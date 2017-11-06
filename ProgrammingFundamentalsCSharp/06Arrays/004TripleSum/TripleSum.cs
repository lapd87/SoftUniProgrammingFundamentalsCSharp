using System;
using System.Collections.Generic;

class TripleSum
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int[] newArray = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            newArray[i] = int.Parse(input[i]);
        }

        bool isSum = false;

        for (int a = 0; a < input.Length; a++)
        {
            for (int b = a + 1; b < input.Length; b++)
            {
                int index = Array.IndexOf(newArray, newArray[a] + newArray[b]);

                if (index > -1)
                {
                    Console.WriteLine($"{newArray[a]} + {newArray[b]} == {newArray[index]}");

                    isSum = true;
                }
            }
        }

        if (!isSum)
        {
            Console.WriteLine("No");
        }
    }
}
