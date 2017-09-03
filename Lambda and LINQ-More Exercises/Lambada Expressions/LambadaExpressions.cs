namespace Lambada_Expressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LambadaExpressions
    {
        public static void Main(string[] args)
        {
            //dictionary for result;
            var result = new Dictionary<string, Dictionary<string, string>>();

            //var for reading the input;
            var input = Console.ReadLine();

            while (input != "lambada")
            {
                //var for splited input;
                var token = input.Split(new []{' ', '.', '=', '>'}, StringSplitOptions.RemoveEmptyEntries);

                //fill  the dictionary;
                if (token.Length > 1)
                {
                    //var for key;
                    var key = token[0];
                    //var for inner key;
                    var innerKey = token[1];
                    //var for innerValue;
                    var innerValue = token[2];

                    if (!result.ContainsKey(key))
                    {
                        result.Add(key, new Dictionary<string,string>());
                    }

                    result[key][innerKey] = innerValue;
                }
                else
                {
                    result = result
                             .ToDictionary(key => key.Key, key => key.Value
                                .ToDictionary(innerKey => innerKey.Key, 
                                    innerKey => innerKey.Key + "." + innerKey.Value));
                }

                input = Console.ReadLine();
            }//end of while loop;

            //printig the result;
            result.ToList()
                    .ForEach(key => key.Value.ToList()
                        .ForEach(innerKey => Console.WriteLine("{0} => {1}.{2}",
                            key.Key,
                            innerKey.Key,
                            innerKey.Value)));
        }
    }
}
