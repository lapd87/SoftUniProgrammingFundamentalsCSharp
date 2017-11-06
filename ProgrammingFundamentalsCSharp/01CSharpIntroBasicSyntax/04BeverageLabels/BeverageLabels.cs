using System;

class BeverageLabels
{
    static void Main()
    {
        string product = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double energyPer100ml = double.Parse(Console.ReadLine());
        double sugarPer100ml = double.Parse(Console.ReadLine());

        Console.WriteLine("{0}ml {1}:", volume,product);
        Console.WriteLine("{0}kcal, {1}g sugars", energyPer100ml*volume/100.0, sugarPer100ml*volume/100.0);
    }
}
