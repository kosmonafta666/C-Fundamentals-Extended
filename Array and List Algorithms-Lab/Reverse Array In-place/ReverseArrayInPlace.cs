namespace Reverse_Array_In_place
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseArrayInPlace
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to list;
            var input = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < input.Count / 2; i++)
            {
                //var left value;
                var leftValue = input[i];
                //var for right value;
                var rightValue = input[(input.Count - 1) - i];
                //var temp value;
                var temp = "";

                temp = leftValue;
                input[i] = rightValue;
                input[(input.Count - 1) - i] = temp;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
