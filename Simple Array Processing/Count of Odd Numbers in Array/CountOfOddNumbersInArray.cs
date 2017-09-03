namespace Count_of_Odd_Numbers_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CountOfOddNumbersInArray
    {
        static void Main(string[] args)
        {
            //read the input, split and convert to integer;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //var odd number count;
            var oddCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {
                    oddCount++;
                }
            }

            Console.WriteLine(oddCount);
        }
    }
}
