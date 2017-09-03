namespace Distance_between_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DistanceBetweenPoints
    {
        public static void Main(string[] args)
        {
            //read the first pair;
            var firstPair = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var x1 = firstPair[0];
            var y1 = firstPair[1];

            //read the second pair;
            var secondPair = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var x2 = secondPair[0];
            var y2 = secondPair[1];

            //var for first point;
            var point1 = new Point();
            point1.X = x1;
            point1.Y = y1;

            //var for first point;
            var point2 = new Point();
            point2.X = x2;
            point2.Y = y2;

            //var for distance;
            var distance = CalcDistance(point1, point2);

            Console.WriteLine("{0:F3}", distance);
        }

        public static double CalcDistance(Point point1, Point point2)
        {
            var a = Math.Abs(point1.X - point2.X);
            var b = Math.Abs(point1.Y - point2.Y);
            var distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return distance;
        }
    }
}
