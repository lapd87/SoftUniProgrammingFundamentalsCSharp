using System;

class TemperatureConversion
{
    static void Main()
    {
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = FahrenheitToCelsius(fahrenheit);

        Console.WriteLine("{0:0.00}", celsius);
    }

    private static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
