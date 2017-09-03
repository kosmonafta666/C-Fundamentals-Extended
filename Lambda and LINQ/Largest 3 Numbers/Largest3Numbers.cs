namespace Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Largest3Numbers
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to real numbers;
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //list for result;
            var result = input.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
