namespace Flip_List_Sides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FlipListSides
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to list;
            var input = Console.ReadLine().Split(' ').ToList();

            for (int i = 1; i < input.Count / 2; i++)
            {
                //var for left index;
                var leftIndex = i;

                //var for right index;
                var rightIndex = (input.Count - 1) - i;

                //var for temp value;
                var temp = "";

                temp = input[leftIndex];
                input[leftIndex] = input[rightIndex];
                input[rightIndex] = temp;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
