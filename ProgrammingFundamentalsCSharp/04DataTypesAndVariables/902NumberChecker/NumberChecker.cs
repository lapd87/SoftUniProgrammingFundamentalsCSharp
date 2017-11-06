using System;

class NumberChecker
{
    static void Main()
    {
        string num = Console.ReadLine();

        if (num.Contains(".") || num.Contains(","))
        {
            Console.WriteLine("floating-point");
        }
        else
        {
            Console.WriteLine("integer");
        }
    }
}
