using System;

class Hotel
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        decimal studioPrice = 0;
        decimal doublePrice = 0;
        decimal suitePrice = 0;
        decimal studioDiscount = 1;
        decimal doubleDiscount = 1;
        decimal suiteDiscount = 1;


        switch (month)
        {
            case "May":
            case "October":
                studioPrice = 50 * nights;
                doublePrice = 65 * nights;
                suitePrice = 75 * nights;
                if (nights > 7)
                {
                    studioDiscount -= 0.05m;
                }
                break;
            case "June":
            case "September":
                studioPrice = 60 * nights;
                doublePrice = 72 * nights;
                suitePrice = 82 * nights;
                if (nights > 14)
                {
                    doubleDiscount -= 0.10m;
                }
                break;
            case "July":
            case "August":
            case "December":
                studioPrice = 68 * nights;
                doublePrice = 77 * nights;
                suitePrice = 89 * nights;
                if (nights > 14)
                {
                    suiteDiscount -= 0.15m;
                }
                break;
        }


        studioPrice *= studioDiscount;
        doublePrice *= doubleDiscount;
        suitePrice *= suiteDiscount;

        if (nights > 7 && (month == "September" || month == "October"))
        {
            studioPrice *= 1 - 1 / (decimal)nights;
        }

        Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        Console.WriteLine($"Double: {doublePrice:f2} lv.");
        Console.WriteLine($"Suite: {suitePrice:f2} lv.");
    }
}
