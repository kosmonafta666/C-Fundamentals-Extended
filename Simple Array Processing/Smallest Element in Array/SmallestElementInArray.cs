namespace Smallest_Element_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SmallestElementInArray
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to double array;
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //var for smallest number;
            var smallestNumber = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] <= smallestNumber)
                {
                    smallestNumber = input[i];
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
