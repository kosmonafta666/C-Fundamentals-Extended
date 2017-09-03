namespace Happiness_Index
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class HappinessIndex
    {
        public static void Main(string[] args)
        {
            //string for happy pattern;
            var happyStr = @"(:\))|(:D)|(;\))|(:\*)|(:])|(;])|(:})|(;\})|(\(:)|(\*:)|(c:)|(\[:)|(\[;)";
            //string for sad pattern;
            var sadStr = @"(:\()|(D:)|(;\()|(:\[)|(;\[)|(:{)|(;{)|(\):)|(:c)|(]:)|(];)";

            //var for happy regex;
            var happyReg = new Regex(happyStr);
            //var for sad regex;
            var sadReg = new Regex(sadStr);

            //var for sentence;
            var sentence = Console.ReadLine();

            //var for happy matches;
            var happyMatches = happyReg.Matches(sentence);
            //var for sad matches;
            var sadMatches = sadReg.Matches(sentence);

            //var for happy index;
            var happyIndex = Math.Round((double)happyMatches.Count / sadMatches.Count, 2);

            //printing the result;
            if (happyIndex >= 2)
            {
                Console.WriteLine("Happiness index: {0:F2} :D", happyIndex);
            }
            else if (happyIndex > 1 && happyIndex < 2)
            {
                Console.WriteLine("Happiness index: {0:F2} :)", happyIndex);
            }
            else if (happyIndex == 1)
            {
                Console.WriteLine("Happiness index: {0:F2} :|", happyIndex);
            }
            else if (happyIndex < 1)
            {
                Console.WriteLine("Happiness index: {0:F2} :(", happyIndex);
            }


            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", happyMatches.Count, sadMatches.Count);
        }
    }
}
