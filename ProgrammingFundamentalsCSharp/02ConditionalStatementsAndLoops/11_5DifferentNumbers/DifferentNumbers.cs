using System;

class DifferentNumbers
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        if (secondNum - firstNum < 5)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = firstNum; i <= secondNum - 4; i++)
            {
                for (int j = i + 1; j <= secondNum - 3; j++)
                {
                    for (int k = j + 1; k <= secondNum - 2; k++)
                    {
                        for (int l = k + 1; l <= secondNum - 1; l++)
                        {
                            for (int m = l + 1; m <= secondNum; m++)
                            {
                                Console.WriteLine($"{i} {j} {k} {l} {m}");
                            }
                        }
                    }
                }
            }
        }
    }
}
