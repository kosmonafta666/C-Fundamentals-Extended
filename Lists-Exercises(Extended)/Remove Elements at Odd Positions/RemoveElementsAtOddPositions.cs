namespace Remove_Elements_at_Odd_Positions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RemoveElementsAtOddPositions
    {
        public static void Main(string[] args)
        {
            //read the input, split and covert to list;
            var input = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0}", input[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
