using System;

class DifferentIntegersSize
{
    static void Main()
    {
        string numberString = Console.ReadLine();
        try
        {
            long num = long.Parse(numberString);

            Console.WriteLine(num + " can fit in:");

            if (num <= sbyte.MaxValue && num >= sbyte.MinValue)
            {
                Console.WriteLine("* sbyte");
            }
            if (num <= byte.MaxValue && num >= byte.MinValue)
            {
                Console.WriteLine("* byte");
            }
            if (num <= short.MaxValue && num >= short.MinValue)
            {
                Console.WriteLine("* short");
            }
            if (num <= ushort.MaxValue && num >= ushort.MinValue)
            {
                Console.WriteLine("* ushort");
            }
            if (num <= int.MaxValue && num >= int.MinValue)
            {
                Console.WriteLine("* int");
            }
            if (num <= uint.MaxValue && num >= uint.MinValue)
            {
                Console.WriteLine("* uint");
            }

            Console.WriteLine("* long");
        }
        catch (Exception)
        {
            Console.WriteLine( numberString + " can't fit in any type");
        }
    }
}
