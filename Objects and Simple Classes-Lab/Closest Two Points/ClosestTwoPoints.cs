namespace Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClosestTwoPoints
    {
        public static void Main(string[] args)
        {
            //read the number of points;
            var numberPoints = int.Parse(Console.ReadLine());

            //list to store points;
            var points = new List<Point>();

            //fill the list with points;
            for (int i = 1; i <= numberPoints; i++)
            {
                //var for input;
                var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                //var for current point;
                var currentPoint = new Point();
                //vars for x and y values;
                var x1 = input[0];
                var y1 = input[1];

                currentPoint.X = x1;
                currentPoint.Y = y1;

                points.Add(currentPoint);
            }//end of for loop;

            //var for closet point;
            var closestPoints = FindClosestPoints(points);

            //print the result;
            Console.WriteLine("{0:F3}", CalcDistance(closestPoints[0], closestPoints[1]));

            foreach (var point in closestPoints)
            {
                Console.WriteLine("({0}, {1})", point.X, point.Y);
            }
        }

        //method to calculate distance between two points;
        public static double CalcDistance(Point point1, Point point2)
        {
            var a = Math.Abs(point1.X - point2.X);
            var b = Math.Abs(point1.Y - point2.Y);
            var distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return distance;
        }

        //method to calculate closest distance between points;
        public static Point[] FindClosestPoints(List<Point> points)
        {
            //var for result;
            var result = new Point[2];
            //var for min distance;
            var minDistance = double.MaxValue;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    //var for distance betwen current points
                    var distance = CalcDistance(points[i], points[j]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;

                        result[0] = points[i];
                        result[1] = points[j];
                    }
                }
            }

            return result;
        }
    }
}
