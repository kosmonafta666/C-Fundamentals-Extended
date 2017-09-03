namespace Average_Character_Delimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AverageCharacterDelimiter
    {
        public static void Main(string[] args)
        {
            //read the input,split and covert to list;
            var input = Console.ReadLine().Split(' ').ToList();

            //list for all chars;
            var chars = new List<char>();

            //fill the chars list;
            foreach (var str in input)
            {
                foreach (char ch in str) 
                {
                    chars.Add(ch);
                }
            }

            //var for average char;
            string averageChar = Char.ToUpper(AverageChar(chars)).ToString();

            Console.WriteLine(string.Join(averageChar , input));
        }

        //method for calculate average char from list char;
        public static char AverageChar(List<char> list)
        {
            //char for the result;
            char resultChar;
            //var average sum; of char list;
            var average = 0.0;
            //var for sum of value of all char in list;
            var sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                //var for current char int value;
                int currentCharValue = (int)list[i];
                sum += currentCharValue;
            }

            average = (int)sum / (list.Count);

            resultChar = (char)average;

            return resultChar;
        }
    }
}
