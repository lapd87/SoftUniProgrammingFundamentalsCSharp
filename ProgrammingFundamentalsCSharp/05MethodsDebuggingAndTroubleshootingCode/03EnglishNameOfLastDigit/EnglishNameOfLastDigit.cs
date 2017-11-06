using System;

class EnglishNameOfLastDigit
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());

        string numToText = LastDigitText(num);

        Console.WriteLine(numToText);
    }

    private static string LastDigitText(long num)
    {
        string[] array = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        return array[Math.Abs(num) % 10];
    }
}
