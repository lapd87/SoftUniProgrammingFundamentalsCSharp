using System;
using System.Globalization;

internal class DayOfWeek
{
    private static void Main()
    {
        string date = Console.ReadLine();

        DateTime day = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine(day.DayOfWeek);
    }
}