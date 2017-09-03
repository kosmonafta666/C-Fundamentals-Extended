namespace Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountNumbers
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var for result list;
            var result = new int[input.Max() + 1];

            //fill the result;
            foreach (var number in input)
            {
                result[number] += 1;
            }

            //printing the result;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    Console.WriteLine("{0} -> {1}", i, result[i]);
                }
            }
        }
    }
}
