namespace Default_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DefaultValues
    {
        public static void Main(string[] args)
        {
            //dictionary for result;
            var result = new Dictionary<string, string>();

            //var for input;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //var for splited input;
                var token = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                //var for key;
                var key = token[0];
                //var for value;
                var value = token[1];

                //fill the dictionary;
                if (!result.ContainsKey(key))
                {
                    result.Add(key, value);
                }
                
                result[key] = value;

                input = Console.ReadLine();
            }//end of while loop;

            //var for replace word;
            var replacedWord = Console.ReadLine();

            //dictionary for none null value;
            var noneNullDict = result.Where(x => x.Value != "null").ToDictionary(x => x.Key, x => x.Value);
            //dictionary for null value;
            var nullDict = result.Where(x => x.Value == "null").ToDictionary(x => x.Key, x => x.Value);

            //print the first dictionary;
            foreach (var item in noneNullDict.OrderByDescending(x => x.Value.Length))
            {
                Console.WriteLine("{0} <-> {1}", item.Key, item.Value);
            }

            //print the second value;
            foreach (var item in nullDict)
            {
                Console.WriteLine("{0} <-> {1}", item.Key, replacedWord);
            }
        }
    }
}
