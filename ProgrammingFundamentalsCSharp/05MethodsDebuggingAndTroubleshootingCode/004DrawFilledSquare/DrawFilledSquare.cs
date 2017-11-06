using System;

internal class DrawFilledSquare
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintFilledSquare(n);
    }

    private static void PrintFilledSquare(int n)
    {
        PrintTopBottom(n);

        for (int row = 2; row <= n - 1; row++)
        {
            PrintMiddle(n);
        }

        PrintTopBottom(n);
    }

    private static void PrintMiddle(int n)
    {
        Console.Write("-");

        for (int col = 1; col <= n - 1; col++)
        {
            Console.Write("\\/");
        }

        Console.WriteLine("-");
    }

    private static void PrintTopBottom(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }
}