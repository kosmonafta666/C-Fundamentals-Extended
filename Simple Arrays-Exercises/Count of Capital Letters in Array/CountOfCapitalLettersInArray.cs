namespace Count_of_Capital_Letters_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountOfCapitalLettersInArray
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to string array;
            var input = Console.ReadLine().Split(' ').ToArray();

            //var for Upper letter count;
            var upperLetterCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //var for current string;
                var curretntString = input[i];

                for (int j = 0; j < curretntString.Length; j++)
                {
                    //var fo current char;
                    char currentChar = curretntString[j];

                    if (char.IsUpper(currentChar))
                    {
                        upperLetterCount++;
                    }
                }//end of second for loop;
            }//end of first for loop;

            Console.WriteLine(upperLetterCount);
        }
    }
}
