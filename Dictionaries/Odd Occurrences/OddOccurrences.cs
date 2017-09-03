namespace Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OddOccurrences
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to list;
            var input = Console.ReadLine()
                .Split(' ')
                .Select(x => x.ToLower())
                .ToList();

            //dictionary for result;
            var result = new Dictionary<string, int>();

            //fill the dictionary;
            for (int i = 0; i < input.Count; i++)
            {
                //var for current string;
                var currentString = input[i];

                if (!result.ContainsKey(currentString))
                {
                    result.Add(currentString, 1);
                }
                else
                {
                    result[currentString]++;
                }
            }//end of fill the dictionary;

            //var for odd result;
            var oddResult = result.Where(x => x.Value % 2 != 0).ToDictionary(x => x.Key, x => x.Value);

            //var for string for values of odd result;
            var strResult = oddResult.Keys.ToArray();

            //print the result;
            Console.WriteLine(string.Join(", ", strResult));
            
        }
    }
}
