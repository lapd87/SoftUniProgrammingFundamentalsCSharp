using System;

class GameOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicalNum = int.Parse(Console.ReadLine());

        int count = 0;
        int nMagic = 0;
        int mMagic = 0;
        bool hasMagic = false;

        for (int i = n; i <= m; i++)
        {
            for (int j = n; j <= m; j++)
            {
                count++;
                if (i + j == magicalNum)
                {
                    nMagic = i;
                    mMagic = j;
                    hasMagic = true;
                }
            }
        }

        if (hasMagic)
        {
            Console.WriteLine($"Number found! {nMagic} + {mMagic} = {nMagic + mMagic}");
        }
        else
        {
            Console.WriteLine($"{count} combinations - neither equals {magicalNum}");
        }
    }
}
