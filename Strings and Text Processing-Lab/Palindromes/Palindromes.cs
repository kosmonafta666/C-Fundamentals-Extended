namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Palindromes
    {
        public static void Main(string[] args)
        {
            //var for input strings;
            var inputStrings = Console.ReadLine().Split(new[] { ' ', ',', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            //var for palindromes words;
            var palindromes = new List<string>();
            
            foreach (var str in inputStrings)
            {
                //bool for checkig the symbols in current string;
                bool flag = true;

                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[(str.Length - 1) - i])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    palindromes.Add(str);
                }
            }//end of foreach loop;

            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(x => x)));
        }
    }
}
