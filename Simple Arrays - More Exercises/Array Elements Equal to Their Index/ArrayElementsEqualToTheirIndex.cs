namespace Array_Elements_Equal_to_Their_Index
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to double array;
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                //var for current number;
                var currentNumber = input[i];

                if (currentNumber == i)
                {
                    Console.Write("{0} ", currentNumber);
                }
            }

            Console.WriteLine();
        }
    }
}
