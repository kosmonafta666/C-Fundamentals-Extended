namespace Min__Max__Sum__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MinMaxSumAverage
    {
        public static void Main(string[] args)
        {
            //read the number of integers
            var n = int.Parse(Console.ReadLine());
            
            //list to store ingers;
            var result = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                //var for current integer;
                var number = int.Parse(Console.ReadLine());

                result.Add(number);
            }

            Console.WriteLine("Sum = {0}", result.Sum());
            Console.WriteLine("Min = {0}", result.Min());
            Console.WriteLine("Max = {0}", result.Max());
            Console.WriteLine("Average = {0}", result.Average());
        }
    }
}
