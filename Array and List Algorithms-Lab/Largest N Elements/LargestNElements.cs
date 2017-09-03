namespace Largest_N_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class LargestNElements
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to integer list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var for largest element;
            var largestElement = int.Parse(Console.ReadLine());

            input = input.OrderByDescending(x => x).ToList();

            for (int i = 0; i < largestElement; i++)
            {
                Console.Write("{0} ", input[i]);
            }

        }
    }
}
