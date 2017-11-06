using System;

internal class MultiplyEvensByOdds
{
    private static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int result = MultipleEvensAndOddSumDigits(num);

        Console.WriteLine(result);
    }

    private static int MultipleEvensAndOddSumDigits(int num)
    {
        int number = Math.Abs(num);

        int sumOdd = 0;
        int sumEven = 0;

        while (number > 0)
        {
            if (number % 10 % 2 == 0)
            {
                sumEven += number % 10;
            }
            else
            {
                sumOdd += number % 10;
            }

            number /= 10;
        }

        return sumOdd * sumEven;
    }
}