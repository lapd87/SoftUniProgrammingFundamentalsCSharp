using System;

class DayOfWeek
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());

        string[] weekDays = {"Invalid Day!", "Monday", "Tuesday", "Wednesday",
                             "Thursday", "Friday", "Saturday", "Sunday" };
        if (dayOfWeek > 7 || dayOfWeek < 0)
        {
            dayOfWeek = 0;
        }

        Console.WriteLine(weekDays[dayOfWeek]);
    }
}
