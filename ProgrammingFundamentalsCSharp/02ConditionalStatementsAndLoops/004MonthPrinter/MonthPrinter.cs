using System;

class MonthPrinter
{
    static void Main()
    {
        int month = int.Parse(Console.ReadLine());

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Error!");
        }
        else
        {
            System.Globalization.DateTimeFormatInfo monthName = new
                System.Globalization.DateTimeFormatInfo();
            Console.WriteLine(monthName.GetMonthName(month));
        }
    }
}
