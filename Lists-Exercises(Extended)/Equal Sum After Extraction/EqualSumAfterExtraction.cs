namespace Equal_Sum_After_Extraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class EqualSumAfterExtraction
    {
        public static void Main(string[] args)
        {
            //read the first list;
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //read the second list;
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                if ( secondList.Contains(firstList[i]) ) 
                {
                    secondList.Remove(firstList[i]);
                }
            }

            //var for sum for first list;
            var sum1 = firstList.Sum();
            //var for sum for second list;
            var sum2 = secondList.Sum();

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes. Sum: {0}", sum1);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sum1 - sum2));
            }
        }
    }
}
