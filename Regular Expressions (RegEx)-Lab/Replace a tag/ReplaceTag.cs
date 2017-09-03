namespace Replace_a_tag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main(string[] args)
        {
            //var for input string;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //string for pattern;
                var pattern = @"<a.*?href=(.+?)>(.+?)<\/a>";
                //var for new regex;
                var regex = new Regex(pattern);

                //var for replace string;
                var replace = @"[URL href=$1]$2[/URL]";
                //var for result string;
                var result = regex.Replace(input, replace);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }//end of while loop;
        }
    }
}
