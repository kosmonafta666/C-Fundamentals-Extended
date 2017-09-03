namespace Last_3_Consecutive_Equal_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Last3ConsecutiveEqualStrings
    {
        public static void Main(string[] args)
        {
            //res the input and spit;
            var input = Console.ReadLine().Split(' ').ToArray();
            
            //var equal strings;
            var equalString = "";

            for (int i = input.Length - 1; i >= 2; i--)
            {
                //var for first string;
                var firstString = input[i];

                //var for second string;
                var secondString = input[i - 1];

                //var for third string;
                var thirdString = input[i - 2];

                if (firstString == secondString && secondString == thirdString)
                {
                    equalString = firstString;
                    break;
                }
                
            }

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("{0} ", equalString);
            }

            Console.WriteLine();
        }
    }
}
