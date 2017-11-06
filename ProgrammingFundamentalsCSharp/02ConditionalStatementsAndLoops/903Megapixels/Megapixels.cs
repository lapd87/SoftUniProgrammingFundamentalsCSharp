using System;

class Megapixels
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        double megaPixel = width / 1000.0 * height / 1000.0;

        Console.WriteLine($"{width}x{height} => {Math.Round(megaPixel, 1)}MP");
    }
}
