using System;

class TheatrePromotion
{
    static void Main()
    {
        string dayType = Console.ReadLine().ToLower();
        int age = int.Parse(Console.ReadLine());

        if (age >= 0 && age <= 18)
        {
            dayType += "1";
        }
        else if (age > 18 && age <= 64)
        {
            dayType += "2";
        }
        else if (age > 64 && age <= 122)
        {
            dayType += "3";
        }

        switch (dayType)
        {
            case "weekday1":
            case "weekday3":
            case "holiday2":
                Console.WriteLine("12$");
                break;
            case "weekday2":
                Console.WriteLine("18$");
                break;
            case "weekend1":
            case "weekend3":
                Console.WriteLine("15$");
                break;
            case "weekend2":
                Console.WriteLine("20$");
                break;
            case "holiday1":
                Console.WriteLine("5$");
                break;
            case "holiday3":
                Console.WriteLine("10$");
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
    }
}
