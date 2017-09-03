namespace Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class Box
    {
        private Point upperLeft;
        private Point upperRight;
        private Point bottomLeft;
        private Point bottomRight;

        public Point UpperLeft
        {
            get { return upperLeft; }
            set { upperLeft = value; }
        }

        public Point UpperRight
        {
            get { return upperRight; }
            set { upperRight = value; }
        }

        public Point BottomLeft 
        {
            get { return bottomLeft; }
            set { bottomLeft = value; }
        }

        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public int Width
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public static int CalculatePerimeter(int width, int height)
        {
            var perimeter = (2 * width) + (2 * height);

            return perimeter;
        }

        public static int CaculateArea(int width, int height)
        {
            var area = width * height;

            return area;
        }
     }
}
