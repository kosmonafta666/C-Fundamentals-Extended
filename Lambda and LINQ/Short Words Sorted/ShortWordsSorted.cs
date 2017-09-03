namespace Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ShortWordsSorted
    {
        public static void Main(string[] args)
        {
            //read the input;
            var input = Console.ReadLine()
                .Split(new char[15] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower());

            //var for result;
            var result = input.Where(x => x.Length < 5).OrderBy(x => x).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
