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
            //read the input, split and convert to integer list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var for smallestValue;
            var smallestValue = int.MaxValue;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= smallestValue)
                {
                    smallestValue = input[i];
                }
            }

            Console.WriteLine(smallestValue);
        }
    }
}
