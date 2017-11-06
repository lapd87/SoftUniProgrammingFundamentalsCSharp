using System;

class CenturiesToMinutes
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());

        long years = 100 * centuries;
        long days = 3652422 * years / 10000;
        long hours = 24 * days;
        long minutes = 60 * hours;

        Console.WriteLine($"{centuries} centuries = {years} years =" +
                          $" {days} days = {hours} hours = {minutes} minutes");
    }
}
