namespace Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle
    {
        private double top;
        private double left;
        private double width;
        private double height;

        public double Top
        {
            get { return top; }
            set { top = value; }
        }

        public double Left
        {
            get { return left; }
            set { left = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Right
        {
            get { return top + width; }
        }

        public double Bottom
        {
            get { return left + height; }
        }
    }
}
