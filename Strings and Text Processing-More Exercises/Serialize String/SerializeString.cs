namespace Serialize_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SerializeString
    {
        public static void Main(string[] args)
        {
            //var for input string;
            var inputString = Console.ReadLine();

            //dictionary for result;
            var result = new Dictionary<char, HashSet<int>>();

            for (int i = 0; i < inputString.Length; i++)
            {
                //var for current synmbol;
                var currentSymbol = inputString[i];

                for (int j = 0; j < inputString.Length; j++)
                {
                    //var for found index of the current symbol;
                    var found = inputString.IndexOf(currentSymbol, j);
                    //check if curent symbol is found iand fill the result;
                    if (found >= 0)
                    {
                        //var for key;
                        var key = currentSymbol;
                        //fill the result;
                        if (!result.ContainsKey(key))
                        {
                            result.Add(key, new HashSet<int>());
                            result[key].Add(found);
                        }
                        else
                        {
                            result[key].Add(found);
                        }
                    }
                }//end of second for loop;
            }//end of first for loop;

            //printing the result;
            foreach (var item in result)
            {
                Console.WriteLine("{0}:{1}", item.Key, string.Join("/", item.Value));
            }
        }
    }
}
