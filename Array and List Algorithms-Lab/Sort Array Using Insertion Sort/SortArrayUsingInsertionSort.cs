namespace Sort_Array_Using_Insertion_Sort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortArrayUsingInsertionSort
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to integer list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                //var temp value;
                var temp = input[i];

                var j = i - 1;

                while (j >= 0 && input[j] > temp)
                {
                    input[j + 1] = input[j];
                    j--;
                }

                input[j + 1] = temp;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
