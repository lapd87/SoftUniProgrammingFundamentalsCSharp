using System;

internal class BlankReceipt
{
    private static void Main()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }

    private static void PrintHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }

    private static void PrintBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    private static void PrintFooter()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("© SoftUni");
    }
}