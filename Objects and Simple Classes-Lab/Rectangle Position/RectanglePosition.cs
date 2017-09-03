namespace Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RectanglePosition
    {
        public static void Main(string[] args)
        {
            //var for first line;
            var firstLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            //var for first rectangle;
            var rect1 = new Rectangle()
            {
                Top = firstLine[0],
                Left = firstLine[1],
                Width = firstLine[2],
                Height = firstLine[3]
            };

            //var for second line;
            var secondLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            //var for second rectangle;
            var rect2 = new Rectangle()
            {
                Top = secondLine[0],
                Left = secondLine[1],
                Width = secondLine[2],
                Height = secondLine[3]
            };

            bool isInside = IsInside(rect1, rect2);

            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else 
            {
                Console.WriteLine("Not inside");
            }
        }

        //method to check first rectangle is inside in second rectangle;
        public static bool IsInside(Rectangle r1, Rectangle r2)
        {
            if (r1.Left >= r2.Left && 
                r1.Right <= r2.Right &&
                r1.Top >= r2.Top &&
                r1.Bottom <= r2.Bottom)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
