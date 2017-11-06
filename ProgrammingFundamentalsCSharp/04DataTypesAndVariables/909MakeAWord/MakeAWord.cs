using System;

class MakeAWord
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        string result = "";

        for (int i = 1; i <= lines; i++)
        {
            result += Console.ReadLine();
        }

        Console.WriteLine($"The word is: {result}");
    }
}
