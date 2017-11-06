namespace RectanglePosition
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Rectangle firstRectangle = ReadRectangle();

            Rectangle secondRectangle = ReadRectangle();

            bool isInside = IsInside(firstRectangle,secondRectangle);

            PrintIsInside(isInside);
        }

        private static void PrintIsInside(bool isInside)
        {
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        private static bool IsInside(Rectangle r1, Rectangle r2)
        {
            bool isInside = r1.TopLeft.X >= r2.TopLeft.X
                && r1.TopLeft.X + r1.Width <= r2.TopLeft.X + r2.Width
                && r1.TopLeft.Y >= r2.TopLeft.Y
                && r1.TopLeft.Y + r1.Height <= r2.TopLeft.Y + r2.Height;

            return isInside;
        }

        private static Rectangle ReadRectangle()
        {
            int[] rectangleInfo = Console.ReadLine()
              .Trim()
              .Split(new string[] { " " }, StringSplitOptions
              .RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            Rectangle rectangle = new Rectangle();

            rectangle.TopLeft = ReadPoint(rectangleInfo[0], rectangleInfo[1]);

            rectangle.Width = rectangleInfo[2];
            rectangle.Height = rectangleInfo[3];

            return rectangle;
        }

        private static Point ReadPoint(int x, int y)
        {
            Point point = new Point();

            point.X = x;
            point.Y = y;

            return point;
        }
    }

    public class Rectangle
    {
        public Point TopLeft { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}