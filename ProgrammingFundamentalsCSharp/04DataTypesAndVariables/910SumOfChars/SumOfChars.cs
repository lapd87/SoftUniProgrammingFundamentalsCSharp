using System;

class SumOfChars
{
    static void Main()
    {
        int chars = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= chars; i++)
        {
            sum += Convert.ToChar(Console.ReadLine());
        }

        Console.WriteLine($"The sum equals: {sum}");
    }
}
