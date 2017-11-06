using System;

class DebitCardNumber
{
    static void Main()
    {
        int firstPart = int.Parse(Console.ReadLine());
        int secondPart = int.Parse(Console.ReadLine());
        int thirdPart = int.Parse(Console.ReadLine());
        int fourthPart = int.Parse(Console.ReadLine());

        Console.WriteLine($"{firstPart:#0000} {secondPart:#0000}" +
            $" {thirdPart:#0000} {fourthPart:#0000}");
    }
}
