namespace Flatten_Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FlattenDictionary
    {
        public static void Main(string[] args)
        {
            //dictionary for result;
            var result = new Dictionary< string, Dictionary<string, string> >();

            //var for input;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //var for splited input;
                var token = input.Split(' ').ToArray();
                
                //fill the dictionary
                if (token[0] != "flatten")
                {
                    //var for key;
                    var key = token[0];
                    //var for inner key;
                    var innerKey = token[1];
                    //var for inner value;
                    var innerValue = token[2];

                    if (!result.ContainsKey(key))
                    {
                        result.Add(key, new Dictionary<string, string>());
                    }
                    else
                    {
                        if (!result[key].ContainsKey(innerKey))
                        {
                            result[key].Add(innerKey, innerValue);
                        }
                    }

                    result[key][innerKey] = innerValue;
                }
                else
                {
                    //flaten the inner key and inner value;
                    var key = token[1];
                    result[key] = result[key].ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                input = Console.ReadLine();
            }//end of while loop;

            //sorted dictionary by key length;
            var sortedDict = result.OrderByDescending(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);

            //printing the result;
            foreach (var item in sortedDict)
            {
                Console.WriteLine("{0}", item.Key);

                //var for count of inner keys;
                var countInnerKeys = 1;

                //dictionary for none flatten keys;
                var noneFlattenDict = item.Value.Where(x => x.Value != "flattened")
                                   .OrderBy(x => x.Key.Length)
                                   .ToDictionary(x => x.Key, x => x.Value);

                //print the none flatten dictionary;
                foreach (var key in noneFlattenDict)
                {
                    Console.WriteLine("{0}. {1} - {2}", countInnerKeys, key.Key, key.Value);
                    countInnerKeys++;
                }

                //dictionary for flatten keys;
                var flattenDict = item.Value
                                .Where(x => x.Value == "flattened")
                                .ToDictionary(x => x.Key, x => x.Value);

                //printing the flatten dictionary;
                foreach (var key in flattenDict)
                {
                    Console.WriteLine("{0}. {1}", countInnerKeys, key.Key);
                    countInnerKeys++;
                }
            }
        }
    }
}
