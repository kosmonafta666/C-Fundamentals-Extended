namespace Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Pyramidic
    {
        public static void Main(string[] args)
        {
            //var for number of strings;
            var n = int.Parse(Console.ReadLine());

            //list for piramids strings;
            var piramids = new List<string>();
            //array for lines;
            string[] lines = new string[n];

            //fill the line array;
            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                //var for current line in lines array;
                var currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    //var current char in current line;
                    var currentChar = currentLine[j];
                    //var for count of matched substring;
                    var count = 3;

                    for (int k = i + 1; k < lines.Length; k++)
                    {
                        //var for matched string;
                        var matchStr = new string(currentChar, count);
                        //add matched string to piramid list;
                        if (lines[k].Contains(matchStr))
                        {
                            piramids.Add(matchStr);
                        }
                        
                        count = count + 2;
                    }//end of third for loop;
                }//end of second for loo;
            }//end of first for loop;

            //take the string with highest length in piramids list;
            var maxStr = piramids.OrderByDescending(x => x.Count()).First();
            //take first char of highest length string;
            var maxChar = maxStr.First();
            //printing the result;
            for (int i = 1; i <= maxStr.Length; i = i + 2)
            {
                Console.WriteLine(new string(maxChar, i));
            }
        }
    }
}
