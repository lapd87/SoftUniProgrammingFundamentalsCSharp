using System;

class IntervalOfNumbers
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        int min = Math.Min(firstNum, secondNum);
        int max = Math.Max(firstNum, secondNum);

        for (int i = min; i <= max; i++)
        {
            Console.WriteLine(i);
        }
    }
}
