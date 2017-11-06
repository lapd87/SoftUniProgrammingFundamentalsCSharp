using System;
using System.Linq;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            return;
        }

        bool[] primesArray = Enumerable.Repeat<bool>(true, n + 1).ToArray();

        primesArray[0] = primesArray[1] = false;

        for (int i = 2; i < Math.Sqrt(n + 1); i++)
        {
            if (primesArray[i])
            {
                for (int j = i * i; j < n + 1; j += i)
                {
                    primesArray[j] = false;
                }
            }
        }

        for (int i = 0; i < primesArray.Length; i++)
        {
            if (primesArray[i])
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}

