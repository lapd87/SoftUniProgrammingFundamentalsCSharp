using System;

class ConvertSpeedUnits
{
    static void Main()
    {
        int meters = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        DateTime time = DateTime.ParseExact($"{hours}:{minutes}:{seconds}", "H:m:s", System.Globalization.CultureInfo.InvariantCulture);
        float totalSeconds = (float)time.TimeOfDay.TotalSeconds;
        float totalHours = (float)time.TimeOfDay.TotalHours;

        float metersPerSecond = meters / totalSeconds;
        float kmPerHour = meters / 1000 / totalHours;
        float milesPerHour = kmPerHour / 1609 * 1000;


        Console.WriteLine(metersPerSecond);
        Console.WriteLine(kmPerHour);
        Console.WriteLine(milesPerHour);
    }
}
