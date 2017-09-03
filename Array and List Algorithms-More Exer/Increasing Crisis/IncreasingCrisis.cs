namespace Increasing_Crisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IncreasingCrisis
    {
        public static void Main(string[] args)
        {
            //read the numbers of the lines;
            var lines = int.Parse(Console.ReadLine());


            //list for result;
            var result = new List<double>();

            for (int i = 1; i <= lines; i++)
            {
                //read the sequence;
                var sequence = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

                if (!result.Any())
                {
                    result.InsertRange(0, sequence);
                }
                else
                {
                    //var first element in sequence;
                    var firstValue = sequence[0];
                    //var for index to insert the first value;
                    var indexInsert = 0;

                    if (firstValue == 0)
                    {
                        indexInsert = 0;
                    }
                    else 
                    {
                        indexInsert = LowerByValue(result, firstValue);
                    }
                     
                    //adding the first value to result;
                    result.Insert(indexInsert, firstValue);
                    //increasing the insert index;
                    indexInsert++;

                    for (int k = 1; k < sequence.Count; k++)
                    {
                        if (sequence[k] >= sequence[k - 1])
                        {
                            result.Insert(indexInsert, sequence[k]);
                            indexInsert++;
                        }
                        else if (sequence[k] < sequence[k - 1])
                        {
                            result.RemoveRange(indexInsert, result.Count - indexInsert);
                            break;
                        }
                    }
                }//end of checking;
            }//end of for loop;

            Console.WriteLine(string.Join(" ", result));
        }

        //method to find the first rightmost value lower by value;
        public static int LowerByValue(List<double> list, double value)
        {
            int result = 0;

            for (int i = list.Count - 1; i > 0; i--)
            {
                if (list[i] <= value)
                {
                    result = i;
                    break;
                }
                else
                {
                    result = (int)value;
                }
            }

            return result + 1;
        }
    }
}
