namespace Sort_Array_Using_Bubble_Sort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortArrayUsingBubbleSort
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to integer list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //bool to check if have swap the values;
            var swapFlag = true;

            while (swapFlag)
            {
                swapFlag = false;

                for (int i = 1; i < input.Count; i++)
                {
                    //var for temp value;
                    var temp = 0;

                    //check if second value is smaller and swaped;
                    if (input[i] < input[i - 1])
                    {
                        temp = input[i];
                        input[i] = input[i - 1];
                        input[i - 1] = temp;
                        swapFlag = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
