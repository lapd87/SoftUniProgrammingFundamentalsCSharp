using System;

internal class PriceChangeAlert
{
    private static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());

        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());

            double diffPercantage = ChangePercantage(lastPrice, currentPrice);

            bool isMinorDiff = DiffType(diffPercantage, threshold);

            string message = Get(currentPrice, lastPrice, diffPercantage, isMinorDiff);

            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string Get(double currentPrice, double lastPrice, double diffPercantage, bool isMinorDiff)

    {
        string message = "";

        if (diffPercantage == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isMinorDiff)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diffPercantage * 100);
        }
        else if (isMinorDiff && (diffPercantage > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diffPercantage * 100);
        }
        else if (isMinorDiff && (diffPercantage < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diffPercantage * 100);
        return message;
    }

    private static bool DiffType(double diffPercantage, double threshold)
    {
        if (Math.Abs(diffPercantage) >= threshold)
        {
            return true;
        }
        return false;
    }

    private static double ChangePercantage(double lastPrice, double currentPrice)
    {
        double changePercantage = (currentPrice - lastPrice) / lastPrice;
        return changePercantage;
    }
}