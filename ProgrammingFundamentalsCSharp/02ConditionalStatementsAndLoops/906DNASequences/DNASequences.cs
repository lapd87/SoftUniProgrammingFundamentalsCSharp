using System;

class DNASequences
{
    static void Main()
    {
        int matchSum = int.Parse(Console.ReadLine());

        char first = 'A';
        char second = 'C';
        char third = 'G';
        char fourth = 'T';


        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    string leading = "X";
                    if (i + j + k >= matchSum)
                    {
                        leading = "O";
                    }

                    Console.Write(leading + numChar(i) + numChar(j) +
                                            numChar(k) + leading + " ");
                }
                Console.WriteLine();
            }
        }
    }

    static char numChar(int num)
    {
        char character = 'a';

        switch (num)
        {
            case 1: character = 'A'; break;
            case 2: character = 'C'; break;
            case 3: character = 'G'; break;
            case 4: character = 'T'; break;
        }

        return character;
    }
}
