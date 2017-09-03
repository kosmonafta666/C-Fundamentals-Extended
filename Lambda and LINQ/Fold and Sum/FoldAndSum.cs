namespace Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to integer numberk
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //var for k number;
            var k = input.Length / 4;

            //var for row 1;
            var row1 = input.Take(k).Reverse();
            //var for row2;
            var row2 = input.Reverse().Take(k);
            //var for first array;
            var firstArray = row1.Concat(row2).ToArray();
            //var for second array;
            var secondArray = input.Skip(k).Take(2 * k).ToArray();
            //array for result;
            var result = new int[2 * k];

            for (int i = 0; i < firstArray.Length; i++)
            {
                result[i] = firstArray[i] + secondArray[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
