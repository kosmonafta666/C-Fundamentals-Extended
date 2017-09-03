namespace Odd_Numbers_at_Odd_Positions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class OddNumbersAtOddPositions
    {
        static void Main(string[] args)
        {
            //read the input, split and convert to integer array;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if ((i % 2 != 0) && (input[i] % 2 != 0))
                {
                    Console.WriteLine("Index {0} -> {1}", i, input[i]);
                }
            }
        }
    }
}
