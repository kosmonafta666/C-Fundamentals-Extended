namespace Array_Histogram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayHistogram
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to string list;
            var input = Console.ReadLine().Split(' ').ToList();
            
            //list of gropus for the result;
            var result = input.GroupBy(w => w).OrderByDescending(x => x.Count()).ToList();

            foreach (var group in result)
            {
                //calculating the percent of occurencies;
                var percent = group.Count() * 100.00 / input.Count;

                Console.WriteLine("{0} -> {1} times ({2:F2}%)", group.First(), group.Count(), percent);
            }
        }
    }
}
