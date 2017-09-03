namespace Letter_Repetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LetterRepetition
    {
        public static void Main(string[] args)
        {
            //read the input and convert to array;
            var input = Console.ReadLine().ToArray();

            //dictionary for result;
            var result = new Dictionary<char, int>();

            //fill the dictionary;
            foreach (char ch in input)
            {
                if (!result.ContainsKey(ch)) 
                {
                    result.Add(ch, 1);
                }
                else
                {
                    result[ch]++;
                }
            }

            //print the result;
            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
