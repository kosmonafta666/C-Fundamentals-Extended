namespace Sort_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortNumbers
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to list;
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            input.Sort();

            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
