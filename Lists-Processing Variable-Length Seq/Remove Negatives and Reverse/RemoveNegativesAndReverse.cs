namespace Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RemoveNegativesAndReverse
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //list for new list;
            List<int> result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] >= 0)
                {
                    result.Add(input[i]);
                }
            }

            //check if have any value in result and print;
            if (result.Any()) 
            {
                result.Reverse();

                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
