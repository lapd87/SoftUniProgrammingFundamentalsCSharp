using System;

internal class PrintingTriangle
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintTriangle(n);
    }

    private static void PrintTriangle(int n)
    {
        for (int row = 1; row <= n; row++)
        {
            PrintLine(row);
            Console.WriteLine();
        }
        for (int row = n - 1; row > 0; row--)
        {
            PrintLine(row);
            Console.WriteLine();
        }
    }

    static void PrintLine(int row)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }
    }
}