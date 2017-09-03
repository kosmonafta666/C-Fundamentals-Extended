namespace Distinct_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DistinctList
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to integer list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var for temp list;
            var resultList = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (!resultList.Contains(input[i]))
                {
                    resultList.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
