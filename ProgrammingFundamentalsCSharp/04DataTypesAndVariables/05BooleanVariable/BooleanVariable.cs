using System;

class BooleanVariable
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (Convert.ToBoolean(input))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
