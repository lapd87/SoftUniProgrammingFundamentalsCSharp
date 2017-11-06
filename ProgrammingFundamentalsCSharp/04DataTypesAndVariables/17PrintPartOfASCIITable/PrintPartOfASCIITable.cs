using System;

class PrintPartOfASCIITable
{
    static void Main()
    {
        int charStartIndex = int.Parse(Console.ReadLine());
        int charEndIndex = int.Parse(Console.ReadLine());

        for (int i = charStartIndex; i <= charEndIndex; i++)
        {
            Console.Write((char)i + " ");
        }
        Console.WriteLine();
    }
}
