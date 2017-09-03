namespace Nilapdromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Nilapdromes
    {
        public static void Main(string[] args)
        {
            //var for input string;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //var for left border;
                var leftBorder = input.Substring(0, input.Length / 2);
                //var for right border;
                var rightBorder = string.Empty;

                //asign right border;
                if (input.Length % 2 == 0)
                {
                    rightBorder = input.Substring(leftBorder.Length);
                }
                else
                {
                    rightBorder = input.Substring(leftBorder.Length + 1);
                }

                //processing left and right border by 
                //removig last char of left border and first char of right border
                //until they match each other;
                while (true)
                {
                    if (leftBorder == rightBorder)
                    {
                        break;
                    }
                    else if (leftBorder != rightBorder)
                    {
                        leftBorder = leftBorder.Substring(0, leftBorder.Length - 1);
                        rightBorder = rightBorder.Substring(1, rightBorder.Length - 1);
                    }
                }//end of second while loop;

                //if have any border left;
                if (leftBorder.Length != 0)
                {
                    //extract core from input string;
                    var core = input.Substring( leftBorder.Length, (input.Length - (2 * leftBorder.Length)) );
                    //if have any core print the nilapdrome;
                    if (core != "")
                    {
                        Console.WriteLine("{0}{1}{0}", core, leftBorder);
                    }
                }
                
                input = Console.ReadLine();
            }//end of while loop;
        }
    }
}
