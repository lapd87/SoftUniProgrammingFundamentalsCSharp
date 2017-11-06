namespace CirclesIntersection
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Circle firstCircle = ReadCircles();
            Circle secondCircle = ReadCircles();

            bool isIntersection = Intersect(firstCircle, secondCircle);

            if (isIntersection)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            double differenceX = firstCircle.Center.X - secondCircle.Center.X;

            double differenceY = firstCircle.Center.Y - secondCircle.Center.Y;

            double distance = Math.Sqrt(differenceX * differenceX + differenceY * differenceY);

            if (distance > firstCircle.Radius + secondCircle.Radius)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static Circle ReadCircles()
        {
            Circle currentCircle = new Circle();

            double[] input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

            Point center = new Point();

            center.X = input[0];
            center.Y = input[1];

            currentCircle.Center = center;
            currentCircle.Radius = input[2];

            return currentCircle;
        }
    }

    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    internal class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }
}