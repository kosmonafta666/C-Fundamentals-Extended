using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Negative_Elements_in_Array
{
    class CountOfNegativeElementsInArray
    {
        static void Main(string[] args)
        {
            //read the number of numbers array;
            var n = int.Parse(Console.ReadLine());

            //var for negative numbers count;
            var negativeNumbersCount = 0;

            for (int i = 1; i <= n; i++)
            {
                //var for number;
                var number = double.Parse(Console.ReadLine());

                if (number < 0)
                {
                    negativeNumbersCount++;
                }
            }

            Console.WriteLine(negativeNumbersCount);
        }
    }
}
