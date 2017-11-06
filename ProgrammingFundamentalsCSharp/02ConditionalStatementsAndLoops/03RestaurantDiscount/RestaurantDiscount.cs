using System;

class RestaurantDiscount
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string package = Console.ReadLine().ToLower();

        string hallName;
        decimal hallPrice = 0;
        decimal packagePrice = 0;
        decimal discount = 0;

        if (groupSize > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }
        else if (groupSize > 100)
        {
            hallPrice = 7500;
            hallName = "Great Hall";
        }
        else if (groupSize > 50)
        {
            hallPrice = 5000;
            hallName = "Terrace";
        }
        else
        {
            hallPrice = 2500;
            hallName = "Small Hall";
        }

        switch (package)
        {
            case "normal":
                packagePrice = 500;
                discount = 0.95m;
                break;
            case "gold":
                packagePrice = 750;
                discount = 0.9m;
                break;
            case "platinum":
                packagePrice = 1000;
                discount = 0.85m;
                break;
        }

        decimal pricePerPerson = Decimal.Multiply((hallPrice + packagePrice), discount) / groupSize;

        Console.WriteLine($"We can offer you the {hallName}");
        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
    }
}
