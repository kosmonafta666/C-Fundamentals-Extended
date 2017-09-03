namespace Decode_Radio_Frequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DecodeRadioFrequencies
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to list;
            var input = Console.ReadLine().Split(' ').ToList();

            //var for count of result array;
            var countArr = CalculateArrCount(input);

            //list for result;
            var result = new char [countArr];

            //fill the result;
            for (int i = 0; i < input.Count; i++) 
            { 
                //array for current input;
                var currentInput = input[i].Split('.').ToArray();

                //var for left half;
                var leftHalf = int.Parse(currentInput[0]);

                //var for right half;
                var rightHalf = int.Parse(currentInput[1]);

                //check for left symbol;
                if (leftHalf > 0)
                {
                    //var symbol to insert in left half of result;
                    var leftSymbol = (char)leftHalf;

                    result[i] = leftSymbol;
                }

                //check for right symbol;
                if (rightHalf > 0)
                {
                    //var for symbol to insert in right half of result;
                    var rightSymbol = (char)rightHalf;

                    result[(result.Length - 1) - i] = rightSymbol;
                }

            }

            Console.WriteLine(string.Join("", result));
        }


        //method for calculating the result array count;
        public static int CalculateArrCount(List<string> list)
        {
            //var for count fo the result array;
            var countArr = 0;

            foreach (var freq in list)
            {
                //array for current frequency;
                var currentFreq = freq.Split('.').ToArray();

                //calculate of count of result array;
                for (int i = 0; i < currentFreq.Length; i++)
                {
                    //var for half of the frequency;
                    var halfFreq = int.Parse(currentFreq[i]);
                    if (halfFreq > 0)
                    {
                        countArr++;
                    }
                }
            }//end of foreach loop;

            return countArr;
        }
    }
}
