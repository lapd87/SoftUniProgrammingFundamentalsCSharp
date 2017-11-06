using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int tempA = a;
        a = b;
        b = tempA;

        Console.WriteLine("Before:");
        Console.WriteLine($"a = {tempA}");
        Console.WriteLine($"b = {a}");
        Console.WriteLine("After:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
}
