using System;

class BPMCounter
{
    static void Main()
    {
        int BPM = int.Parse(Console.ReadLine());
        int beats = int.Parse(Console.ReadLine());

        double bars = beats / 4.0;
        int minutes = beats / BPM;
        int seconds = (beats - minutes * BPM) * 60 / BPM;

        Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");
    }
}
