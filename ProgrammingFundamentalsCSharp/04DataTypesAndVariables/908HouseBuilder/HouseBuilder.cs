using System;

class HouseBuilder
{
    static void Main()
    {
        uint firstPrice = uint.Parse(Console.ReadLine());
        uint secondPrice = uint.Parse(Console.ReadLine());

        sbyte sbytePrice = (sbyte)Math.Min(firstPrice, secondPrice);
        uint intPrice = Math.Max(firstPrice, secondPrice);

        ulong totalPrice = 4 * (ulong)sbytePrice + 10 * (ulong)intPrice;

        Console.WriteLine(totalPrice);
    }
}
