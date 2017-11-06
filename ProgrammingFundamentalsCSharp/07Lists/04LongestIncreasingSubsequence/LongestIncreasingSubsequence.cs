using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int[] longestLeftCount = new int[nums.Length];
        int[] previousIndex = new int[nums.Length];

        int maxLengthIndex = 0;
        int maxLength = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            longestLeftCount[i] = 1;
            previousIndex[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j] &&
                            longestLeftCount[j] >= longestLeftCount[i])
                {
                    longestLeftCount[i] = longestLeftCount[j] + 1;
                    previousIndex[i] = j;
                }
            }

            if (longestLeftCount[i] > maxLength)
            {
                maxLength = longestLeftCount[i];
                maxLengthIndex = i;
            }
        }

        List<int> result = new List<int> { };

        while (maxLengthIndex > -1)
        {
            result.Add(nums[maxLengthIndex]);
            maxLengthIndex = previousIndex[maxLengthIndex];
        }

        result.Reverse();

        Console.WriteLine(string.Join(" ", result));
    }
}
