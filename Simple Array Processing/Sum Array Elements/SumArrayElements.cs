namespace Sum_Array_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class SumArrayElements
    {
        static void Main(string[] args)
        {
            //read the number of the of int array;
            var n = int.Parse(Console.ReadLine());

            //var for total sum;
            var totalSum = 0;

            for (int i = 1; i <= n; i++)
            {
                //read the integer;
                var number = int.Parse(Console.ReadLine());

                //calculate the total sum;
                totalSum += number;
            }

            Console.WriteLine(totalSum);
        }
    }
}
