using System;

class TheaThePhotographer
{
    static void Main()
    {
        int pictures = int.Parse(Console.ReadLine());
        int filterSecondsPerPicture = int.Parse(Console.ReadLine());
        double goodPicturesPercantage = int.Parse(Console.ReadLine()) / 100.0;
        int uploadSecondsPerPicture = int.Parse(Console.ReadLine());

        long filterSeconds = (long)pictures * filterSecondsPerPicture;
        int goodPictures = (int)Math.Ceiling(pictures * goodPicturesPercantage);
        long uploadSeconds = (long)goodPictures * uploadSecondsPerPicture;

        long totalSeconds = filterSeconds + uploadSeconds;

        TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

        string totalTime = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                                         time.Days,
                                         time.Hours,
                                         time.Minutes,
                                         time.Seconds);

        Console.WriteLine(totalTime);
    }
}
