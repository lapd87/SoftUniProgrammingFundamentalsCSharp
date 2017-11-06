using System;

class X
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n / 2; row++)
        {
            Console.WriteLine(new string(' ', row) + "x" +
                              new string(' ', n - 2 - 2 * row) + "x");
        }
        Console.WriteLine(new string(' ', n / 2) + "x");
        for (int row = n / 2 - 1; row >= 0 / 2; row--)
        {
            Console.WriteLine(new string(' ', row) + "x" +
                              new string(' ', n - 2 - 2 * row) + "x");
        }
    }
}
