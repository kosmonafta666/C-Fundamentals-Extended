namespace Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumAdjacentEqualNumbers
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to list;
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                //var for current value;
                var currentValue = input[i];

                //var for next value;
                var nextValue = input[i + 1];

                if (currentValue == nextValue)
                {
                    input[i] = currentValue + nextValue;
                    input.RemoveAt(i + 1);
                    i = -1;
                }

            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
