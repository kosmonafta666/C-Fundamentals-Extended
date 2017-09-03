namespace Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Boxes
    {
        public static void Main(string[] args)
        {
            //list for boxes objects;
            var boxes = new List<Box>();

            //var for input;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //var for splitted input;
                var token = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();


                //var for upperleft point;
                var upperLeft = new Point()
                {
                    X = int.Parse(token[0].Split(':')[0]),
                    Y = int.Parse(token[0].Split(':')[1])
                };
               
                //var for upperRight point;
                var upperRight = new Point()
                {
                    X = int.Parse(token[1].Split(':')[0]),
                    Y = int.Parse(token[1].Split(':')[1])
                };

                //var for bottomLeft point;
                var bottomLeft = new Point()
                {
                    X = int.Parse(token[2].Split(':')[0]),
                    Y = int.Parse(token[2].Split(':')[1])
                };

                //var for bottomRight point;
                var bottomRight = new Point()
                {
                    X = int.Parse(token[2].Split(':')[0]),
                    Y = int.Parse(token[2].Split(':')[1])
                };

                //var for current box object;
                var currentBox = new Box()
                {
                    UpperLeft = upperLeft,
                    UpperRight = upperRight,
                    BottomLeft = bottomLeft,
                    BottomRight = bottomRight,
                    Width = (int)Point.CalculateDistance(upperLeft, upperRight),
                    Height = (int)Point.CalculateDistance(upperLeft, bottomLeft)
                };

                boxes.Add(currentBox);

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var box in boxes)
            {
                Console.WriteLine("Box: {0}, {1}", box.Width, box.Height);
                Console.WriteLine("Perimeter: {0}", Box.CalculatePerimeter(box.Width, box.Height));
                Console.WriteLine("Area: {0}", Box.CaculateArea(box.Width, box.Height));
            }
        }
    }
}
