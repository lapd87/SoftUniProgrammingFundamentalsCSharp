namespace DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

            double distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            int deltaX = firstPoint.X - secondPoint.X;
            int deltaY = firstPoint.Y - secondPoint.Y;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }

        private static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine()
                          .Trim()
                          .Split(new string[] { " " }, StringSplitOptions
                          .RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();

            Point point = new Point();

            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}