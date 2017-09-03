namespace Text_Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextFilter
    {
        public static void Main(string[] args)
        {
            //var for banned strings;
            var bannedStrings = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            //var for string to replace;
            var inputString = Console.ReadLine();

            //repalce banned words with asterisks;
            foreach (var str in bannedStrings)
            {
                inputString = inputString.Replace(str, new string('*', str.Length));
            }

            Console.WriteLine(inputString);
        }
    }
}