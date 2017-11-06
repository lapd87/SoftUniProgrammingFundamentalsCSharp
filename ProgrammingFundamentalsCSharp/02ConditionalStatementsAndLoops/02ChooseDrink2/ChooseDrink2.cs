using System;

class ChooseDrink2
{
    static void Main()
    {
        string profession = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double price;

        switch (profession)
        {
            case "Athlete":
                price = 0.70;
                break;
            case "Businessman":
            case "Businesswoman":
                price = 1.00;
                break;
            case "SoftUni Student":
                price = 1.70;
                break;
            default:
                price = 1.20;
                break;
        }

        Console.WriteLine($"The {profession} has to pay {price * quantity:F2}.");
    }
}

