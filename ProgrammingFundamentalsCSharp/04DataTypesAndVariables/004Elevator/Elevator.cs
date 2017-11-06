using System;

class Elevator
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        double courses = (double)people / capacity;

        Console.WriteLine(Math.Ceiling(courses));
    }
}
