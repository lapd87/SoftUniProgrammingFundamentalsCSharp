namespace ClosestTwoPoints
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Point[] input = ReadPoints();

            Point[] closest = ClosestPoints(input);

            PrintDistance(closest[0], closest[1]);

            PrintPoint(closest[0]);
            PrintPoint(closest[1]);
        }

        private static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        private static void PrintDistance(Point point1, Point point2)
        {
            double distance = CalcDistance(point1, point2);

            Console.WriteLine("{0:f3}", distance);
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            int deltaX = firstPoint.X - secondPoint.X;
            int deltaY = firstPoint.Y - secondPoint.Y;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }

        private static Point[] ClosestPoints(Point[] points)
        {
            double minDistance = double.MaxValue;

            Point[] closestTwoPoints = new Point[2];

            for (int i = 0; i < points.Count(); i++)
            {
                for (int j = i + 1; j < points.Count(); j++)
                {
                    double distance = CalcDistance(points[i], points[j]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;

                        closestTwoPoints = new Point[] { points[i], points[j] };
                    }
                }
            }

            return closestTwoPoints;
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

        private static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}