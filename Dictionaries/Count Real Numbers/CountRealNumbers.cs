namespace Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountRealNumbers
    {
        public static void Main(string[] args)
        {
            //read the inpuyt, split and convrt to list;
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            //dictionary for result;
            var result = new Dictionary<double, int>();

            //fill the dictionary;
            for (int i = 0; i < input.Count; i++)
            {
                //var for current number;
                var currentNumber = input[i];

                if (!result.ContainsKey(currentNumber))
                {
                    result.Add(currentNumber, 1);
                }
                else
                {
                    result[currentNumber]++;
                }
            }//end of fill the dictionary;

            foreach (var item in result.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
