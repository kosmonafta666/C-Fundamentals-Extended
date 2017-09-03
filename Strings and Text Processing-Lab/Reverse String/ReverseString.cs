namespace Reverse_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseString
    {
        public static void Main(string[] args)
        {
            //var for input string;
            var str = Console.ReadLine();

            //var for reversed string;
            var reverseStr = new string(str.Reverse().ToArray());

            Console.WriteLine(reverseStr);

        }
    }
}
