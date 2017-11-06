namespace PokeMon
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int currentPower = power;
            int pokesCount = 0;

            while (currentPower >= distance)
            {
                currentPower -= distance;
                pokesCount++;

                if ((currentPower * 2).Equals(power) && exhaustion != 0)
                {
                    currentPower /= exhaustion;
                }
            }

            Console.WriteLine(currentPower);
            Console.WriteLine(pokesCount);
        }
    }
}