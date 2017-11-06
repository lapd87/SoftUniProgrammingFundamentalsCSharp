using System;

class PhotoGallery
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        double size = double.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        string sizeType;
        string orientation;

        if (size < 1000)
        {
            sizeType = "B";
        }
        else if (size < 1000000)
        {
            sizeType = "KB";
            size /= 1000;
        }
        else
        {
            sizeType = "MB";
            size /= 1000000.0;
        }

        if (width > height)
        {
            orientation = "landscape";
        }
        else if (height > width)
        {
            orientation = "portrait";
        }
        else
        {
            orientation = "square";
        }

        Console.WriteLine($"Name: DSC_{num:d4}.jpg");
        Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
        Console.WriteLine($"Size: {size}{sizeType}");
        Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
    }
}
