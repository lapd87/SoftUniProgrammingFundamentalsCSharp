using System;

class CountInteger
{
    static void Main()
    {
        int count = 0;

        while (true)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                count++;
            }
            catch (Exception)
            {
                Console.WriteLine(count);
                return;
            }
        }

    }
}
