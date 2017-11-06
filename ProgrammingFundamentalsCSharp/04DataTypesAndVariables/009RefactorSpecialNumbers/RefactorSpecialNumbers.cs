using System;

class RefactorSpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int num = 0;
            num = i;

            int newNum = num;
            int sum = 0;

            while (newNum > 0)
            {
                sum += newNum % 10;
                newNum = newNum / 10;
            }

            bool isSpecial = false;
            isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

            Console.WriteLine($"{num} -> {isSpecial}");
        }
    }
}
