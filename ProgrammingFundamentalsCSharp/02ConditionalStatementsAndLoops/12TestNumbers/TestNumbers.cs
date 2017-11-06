using System;

class TestNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int boundary = int.Parse(Console.ReadLine());

        int sum = 0;
        int count = 0;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                sum += i * j * 3;
                count++;

                if (sum >= boundary)
                {
                    Console.WriteLine(count + " combinations");
                    Console.WriteLine($"Sum: {sum} >= {boundary}");
                    return;
                }
            }
        }

        Console.WriteLine(count + " combinations");
        Console.WriteLine("Sum: " + sum);
    }
}
