using System;

internal class HelloName
{
    private static void Main()
    {
        string name = Console.ReadLine();

        PrintHello(name);
    }

    private static void PrintHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}