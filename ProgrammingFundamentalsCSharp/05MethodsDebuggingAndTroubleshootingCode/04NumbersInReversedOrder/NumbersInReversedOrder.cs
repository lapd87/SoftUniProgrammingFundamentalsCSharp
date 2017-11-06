using System;

class NumbersInReversedOrder
{
    static void Main()
    {
        string number = Console.ReadLine();

        string reversedNum = GetReversed(number);

        Console.WriteLine(reversedNum);
    }

    private static string GetReversed(string number)
    {
        string reversed = "";

        for (int i = number.Length - 1; i >= 0; i--)
        {
            reversed += number[i];
        }

        return reversed;
    }
}
