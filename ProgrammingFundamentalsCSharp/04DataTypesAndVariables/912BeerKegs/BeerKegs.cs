using System;

class BeerKegs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string bestKeg = "";
        double maxVolume = double.MinValue;

        for (int i = 1; i <= n; i ++)
        {
            string kegModel = Console.ReadLine();
            double kegRadius = double.Parse(Console.ReadLine());
            double kegHeight = double.Parse(Console.ReadLine());

            double volume = Math.PI * kegRadius * kegRadius * kegHeight;

            if (volume > maxVolume)
            {
                maxVolume = volume;
                bestKeg = kegModel;
            }
        }

        Console.WriteLine(bestKeg);
    }
}
