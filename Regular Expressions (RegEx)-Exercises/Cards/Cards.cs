namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class Cards
    {
        public static void Main(string[] args)
        {
            //var for input string;
            var input = Console.ReadLine();

            //var for pattern string;
            var pattern = @"([1]?[0-9JQKA])([SHDC])";
            //var for regex object;
            var regex = new Regex(pattern);

            //var for matches in input string;
            var matches = regex.Matches(input);
            //var list for valid cards
            var validCard = new List<string>();

            foreach (Match match in matches)
            {
                //var power of current card;
                var power = 0;

                //if power is smaller then 2 or bigger then 10;
                if (int.TryParse(match.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                //adding valid card to card list;
                validCard.Add(match.ToString());
            }

            //printing the result;
            Console.WriteLine(string.Join(", ", validCard));
        }
    }
}
