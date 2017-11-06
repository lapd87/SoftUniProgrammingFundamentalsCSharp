using System;

class DecryptingMessage
{
    static void Main()
    {
        byte key = byte.Parse(Console.ReadLine());
        byte lines = byte.Parse(Console.ReadLine());

        string message = "";

        for (int i = 1; i <= lines; i++)
        {
            char letter = Convert.ToChar(Console.ReadLine());
            letter += Convert.ToChar(key);
            message += letter;
        }

        Console.WriteLine(message);
    }
}
