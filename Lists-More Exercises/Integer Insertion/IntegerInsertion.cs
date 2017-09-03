namespace Integer_Insertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IntegerInsertion
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to integer list;
            var input = Console.ReadLine().Split(' ').ToList();

            //list for temporary result;
            var tempList = new List<string>();
            
            //read the integer from console to the command end;
            var number = Console.ReadLine();

            while (number != "end")
            {
                
                //var for index to insert the number;
                int insertIndex = (int)char.GetNumericValue(number[0]);
               
                //fill the temporary result to insertIndex;
                for (int i = 0; i < insertIndex; i++)
                {
                    tempList.Add(input[i]);
                }

                //add the number in insert index;
                tempList.Add(number);

                //fill the temporary result from insert index;
                for (int i = insertIndex; i < input.Count; i++) 
                {
                    tempList.Add(input[i]);
                }

                //clear the input;
                input.Clear();

                //fill the input with temp list;
                for (int i = 0; i < tempList.Count; i++)
                {
                    input.Add(tempList[i]);
                }

                //clear the temporary list;
                tempList.Clear();

                number = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
