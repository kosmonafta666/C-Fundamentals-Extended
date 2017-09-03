namespace Insertion_Sort_Using_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InsertionSortUsingList
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to integer list;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //list for result;
            var result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                //boll for insert;
                bool inserted = false;

                //var for current input value;
                var currInputValue = input[i];

                for (int j = 0; j < result.Count; j++)
                {
                    if (currInputValue <= result[j])
                    {
                        result.Insert(j, currInputValue);
                        inserted = true;
                        break;
                    }
                }

                if (!inserted)
                {
                    result.Add(currInputValue);
                }
            }

                Console.WriteLine(string.Join(" ", result));
        }
    }
}
