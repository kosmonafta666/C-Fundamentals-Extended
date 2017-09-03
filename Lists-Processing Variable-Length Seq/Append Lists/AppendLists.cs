namespace Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AppendLists
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to array strings;
            var input = Console.ReadLine().Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //list for result;
            List<string> result = new List<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                //var for current string;
                var currentString = string.Join(" ", input[i].Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
                result.Add(currentString);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
