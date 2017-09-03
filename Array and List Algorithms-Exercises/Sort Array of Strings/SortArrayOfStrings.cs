namespace Sort_Array_of_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortArrayOfStrings
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to list string;
            var input = Console.ReadLine().Split(' ').ToList();

            //bool to check if have swap the values;
            var swapFlag = true;

            while (swapFlag)
            {
                swapFlag = false;

                for (int i = 1; i < input.Count; i++)
                {
                    //var for temp value;
                    var temp = "";

                    //var for result of comparing of strings;
                    var compare = input[i].CompareTo(input[i - 1]);

                    if (compare == -1)
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
