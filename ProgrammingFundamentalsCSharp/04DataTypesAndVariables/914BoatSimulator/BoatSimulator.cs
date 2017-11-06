using System;

internal class BoatSimulator
{
    private static void Main()
    {
        char firstBoat = Convert.ToChar(Console.ReadLine());
        char secondBoat = Convert.ToChar(Console.ReadLine());
        byte lines = byte.Parse(Console.ReadLine());

        byte firstBoatTiles = 0;
        byte secondBoatTiles = 0;

        for (byte i = 1; i <= lines; i++)
        {
            string boatSpeed = Console.ReadLine();

            if (boatSpeed == "UPGRADE")
            {
                firstBoat += (char)3;
                secondBoat += (char)3;
            }
            else
            {
                if (i % 2 != 0)
                {
                    firstBoatTiles += (byte)boatSpeed.Length;
                }
                else
                {
                    secondBoatTiles += (byte)boatSpeed.Length;
                }
            }

            if (firstBoatTiles >= 50)
            {
                Console.WriteLine(firstBoat);
                return;
            }
            if (secondBoatTiles >= 50)
            {
                Console.WriteLine(secondBoat);
                return;
            }
        }
        if (firstBoatTiles > secondBoatTiles)
        {
            Console.WriteLine(firstBoat);
        }
        else
        {
            Console.WriteLine(secondBoat);
        }
    }
}