using System;

class NumberChecker
{
    static void Main()
    {

        try
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
