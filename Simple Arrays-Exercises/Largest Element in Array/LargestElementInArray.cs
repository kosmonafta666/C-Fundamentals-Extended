namespace Largest_Element_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            //read the number of integer arrays;
            var n = int.Parse(Console.ReadLine());

            //var for max value of integers array;
            var maxValue = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                //read the ingeger number;
                var number = int.Parse(Console.ReadLine());

                if (number >= maxValue)
                {
                    maxValue = number;
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
