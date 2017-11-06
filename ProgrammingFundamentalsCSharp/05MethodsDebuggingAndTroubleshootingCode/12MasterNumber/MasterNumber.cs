using System;

class MasterNumber
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        for (long i = 1; i <= n; i++)
        {
            if (IsSymmetric(i) && SumDigitsDiv7(i) && EvenDigit(i))
            {
                Console.WriteLine(i);
            }
        }

    }

    private static bool EvenDigit(long i)
    {
        long num = i;

        while (num >= 10)
        {
            if (num % 2 == 0)
            {
                return true;
            }

            num /= 10;
        }

        return false;
    }

    private static bool SumDigitsDiv7(long i)
    {
        long num = i;

        long sumDigits = 0;

        while (num > 0)
        {
            sumDigits += num % 10;
            num /= 10;
        }

        if (sumDigits % 7 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool IsSymmetric(long i)
    {
        string number = i.ToString();

        for (int j = 0; j < number.Length - 1; j++)
        {
            if (number[j] == number[number.Length - 1 - j])
            {
                continue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
