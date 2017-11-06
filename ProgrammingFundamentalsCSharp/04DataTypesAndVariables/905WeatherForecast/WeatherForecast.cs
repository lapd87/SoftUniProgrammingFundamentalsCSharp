using System;

class WeatherForecast
{
    static void Main()
    {
        try
        {
            long num = long.Parse(Console.ReadLine());

            if (num <= sbyte.MaxValue && num >= sbyte.MinValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (num <= int.MaxValue && num >= int.MinValue)
            {
                Console.WriteLine("Cloudy");
            }
            else
            {
                Console.WriteLine("Windy");
            }
        }
        catch (Exception)
        {

            Console.WriteLine("Rainy");
        }
    }
}

