using System;

internal class CubeProperties
{
    private static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine();

        double result = 0;

        switch (parameter)
        {
            case "face": result = FaceDiagonal(side); break;
            case "space": result = SpaceDiagonal(side); break;
            case "volume": result = Math.Pow(side, 3); break;
            case "area": result = 6 * side * side; break;
        }

        Console.WriteLine($"{result:f2}");
    }

    private static double SpaceDiagonal(double side)
    {
        double spaceDiagonal = Math.Sqrt(Math.Pow(FaceDiagonal(side), 2) + side * side);
        return spaceDiagonal;
    }

    private static double FaceDiagonal(double side)
    {
        double faceDiagonal = Math.Sqrt(2 * side * side);
        return faceDiagonal;
    }
}