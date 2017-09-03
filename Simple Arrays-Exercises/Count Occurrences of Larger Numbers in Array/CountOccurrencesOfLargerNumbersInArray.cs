namespace Count_Occurrences_of_Larger_Numbers_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountOccurrencesOfLargerNumbersInArray
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to double array;
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //var for largest number;
            var largestNumber = double.Parse(Console.ReadLine());

            //var for count of occurrences of larger number;
            var countOfOccurrences = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= largestNumber)
                {
                    countOfOccurrences++;
                }
            }

            Console.WriteLine(countOfOccurrences);
        }
    }
}
