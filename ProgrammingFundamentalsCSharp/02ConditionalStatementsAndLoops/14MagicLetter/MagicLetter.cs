using System;

class MagicLetter
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();
        string thirdLine = Console.ReadLine();

        char firstLetter = firstLine[0];
        char secondLetter = secondLine[0];
        char excludeLetter = thirdLine[0];

        for (char i = firstLetter; i <= secondLetter; i++)
        {
            for (char j = firstLetter; j <= secondLetter; j++)
            {
                for (char k = firstLetter; k <= secondLetter; k++)
                {
                    if (i != excludeLetter && j != excludeLetter && k != excludeLetter)
                    {
                        Console.Write("" + i + j + k + " ");
                    }
                }
            }
        }
    }
}
