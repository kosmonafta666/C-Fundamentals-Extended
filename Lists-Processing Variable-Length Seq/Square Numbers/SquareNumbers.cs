namespace Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SquareNumbers
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //list for the result;
            var result = new List<int>();

            foreach (var number in input)
            {
                //var square rrot of a number;
                var squareRootNumber = Math.Sqrt(number);

                if (squareRootNumber == (int)squareRootNumber)
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result.OrderByDescending(x => x)));
        }
    }
}
