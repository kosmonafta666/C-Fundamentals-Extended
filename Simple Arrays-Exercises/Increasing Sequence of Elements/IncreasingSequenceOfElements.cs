namespace Increasing_Sequence_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IncreasingSequenceOfElements
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to double array;
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //bool to check if sequence is increase;
            bool flag = true;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] >= input[i + 1])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
