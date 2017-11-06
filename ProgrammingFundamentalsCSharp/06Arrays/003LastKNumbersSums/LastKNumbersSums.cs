using System;

class LastKNumbersSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] newArray = new long[n];

        newArray[0] = 1;

        for (int i = 1; i < n; i++)
        {
            long sum = 0;

            for (int j = i - k; j <= i; j++)
            {
                if (j >= 0)
                {
                    sum += newArray[j];
                }
            }

            newArray[i] = sum;
        }

        foreach (var item in newArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
