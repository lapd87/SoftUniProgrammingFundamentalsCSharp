using System;

class WaterOverflow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        byte pouredLitres = 0;

        while (n > 0)
        {
            try
            {
                byte litres = byte.Parse(Console.ReadLine());

                if (pouredLitres + litres <= 255)
                {
                    pouredLitres += litres;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

                n--;
            }
            catch (Exception)
            {
                Console.WriteLine("Insufficient capacity!");
                n--;
            }
        }

        Console.WriteLine(pouredLitres);
    }
}
