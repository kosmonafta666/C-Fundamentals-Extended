using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            //var for input string;
            var inputStr = Console.ReadLine().ToLower();
            //var for pattern string;
            var pattern = Console.ReadLine().ToLower();
            //var count occurrences;
            int count = 0;


            for (int i = 0; i < inputStr.Length; i++)
            {
                var foundIndex = inputStr.IndexOf(pattern, i);

                if (foundIndex >= 0)
                {
                    count++;
                    i = foundIndex;
                }
            }

            Console.WriteLine(count);
        }
    }
}
