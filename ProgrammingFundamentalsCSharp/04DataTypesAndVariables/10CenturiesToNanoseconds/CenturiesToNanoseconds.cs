using System;

class CenturiesToNanoseconds
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());

        long years = 100 * centuries;
        long days = 3652422 * years / 10000;
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        decimal milliseconds = seconds * 1000;
        decimal microseconds = milliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = " +
                          $"{days} days = {hours} hours = " +
                          $"{minutes} minutes = {seconds} seconds = " +
                          $"{milliseconds} milliseconds = " +
                          $"{microseconds} microseconds = " +
                          $"{nanoseconds} nanoseconds");
    }
}
