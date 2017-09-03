namespace Tear_List_in_Half
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TearListInHalf
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //list fot result;
            var result = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                //var for half of the list;
                var half = input.Count / 2;

                //var for first digit;
                int firstDigit = input[half + i] / 10;

                //var for second difit;
                int secondDigit = input[half + i] % 10;

                result.Add(firstDigit);
                result.Add(input[i]);
                result.Add(secondDigit);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
