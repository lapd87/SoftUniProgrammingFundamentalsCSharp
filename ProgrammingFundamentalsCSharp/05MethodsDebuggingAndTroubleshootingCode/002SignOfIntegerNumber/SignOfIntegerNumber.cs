using System;

class SignOfIntegerNumber
{
    static void Main()
    {
        IntegerSign();
    }

    static void IntegerSign()
    {
        string number = Console.ReadLine();

        if (number[0] == '-')
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else if (number == "0")
        {
            Console.WriteLine($"The number {number} is zero.");
        }
        else
        {
            Console.WriteLine($"The number {number} is positive.");
        }
    }
}
