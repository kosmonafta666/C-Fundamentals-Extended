namespace Placeholders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Placeholders
    {
        public static void Main(string[] args)
        {

            var input = Console.ReadLine();


            while (input != "end")
            {
                //var for splitted input;
                var token = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                //var for printed string;
                var printStr = token[0].Trim();
                //var for elements to insert;
                var elements = token[1].Trim().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}";

                    printStr = printStr.Replace(currentPlaceholder, elements[i]);
                }

                Console.WriteLine(printStr);

                input = Console.ReadLine();
            }
        }
    }
}
