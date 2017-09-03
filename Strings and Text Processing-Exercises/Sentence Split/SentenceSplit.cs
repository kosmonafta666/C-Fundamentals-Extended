namespace Sentence_Split
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SentenceSplit
    {
        public static void Main(string[] args)
        {
            //var for input string;
            var inputString = Console.ReadLine();
            //var for delimeter string;
            var delimeterString = Console.ReadLine();
            //var for result;
            var result = inputString.Split(new string []{delimeterString}, StringSplitOptions.None);
            //printing the result;
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}
