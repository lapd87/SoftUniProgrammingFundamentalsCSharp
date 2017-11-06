using System;

class IntegerToHexAndBinary
{
    static void Main()
    {

        int num = int.Parse(Console.ReadLine());

        string numHEX = Convert.ToString(num, 16).ToUpper();
        string numBinary = Convert.ToString(num, 2);

        Console.WriteLine(numHEX);
        Console.WriteLine(numBinary);        
    }
}
