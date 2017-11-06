using System;

class TouristInformation
{
    static void Main()
    {
        string imperialUnit = Console.ReadLine().ToLower();
        double imperialValue = double.Parse(Console.ReadLine());

        double metricValue = 0;
        string metricUnit = "";

        switch (imperialUnit)
        {
            case "miles":
                metricValue = imperialValue * 1.6;
                metricUnit = "kilometers";
                break;
            case "inches":
                metricValue = imperialValue * 2.54;
                metricUnit = "centimeters";
                break;
            case "feet":
                metricValue = imperialValue * 30;
                metricUnit = "centimeters";
                break;
            case "yards":
                metricValue = imperialValue * 0.91;
                metricUnit = "meters";
                break;
            case "gallons":
                metricValue = imperialValue * 3.8;
                metricUnit = "liters";
                break;
        }

        Console.WriteLine($"{imperialValue} {imperialUnit} = {metricValue:f2} {metricUnit}");
    }
}
