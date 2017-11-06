using System;

class PrimesInGivenRange
{
    static void Main()
    {
        long firstNum = long.Parse(Console.ReadLine());
        long secondNum = long.Parse(Console.ReadLine());

        string resultList = PrimesInRange(firstNum, secondNum);

        Console.WriteLine(resultList);

    }

    private static string PrimesInRange(long firstNum, long secondNum)
    {
        string resultList = "";

        for (long i = firstNum; i <= secondNum; i++)
        {
            if (IsPrime(i))
            {
                resultList += (i + ", ");
            }
        }

        return resultList.Remove(resultList.Length - 2);

    }

    private static bool IsPrime(long num)
    {
        long i = 2;

        if (num < i)
        {
            return false;
        }

        while (i <= Math.Sqrt(num))
        {
            if (num % i == 0)
            {
                return false;
            }
            i++;
        }

        return true;
    }
}
