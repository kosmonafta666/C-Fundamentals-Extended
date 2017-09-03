namespace Dict_Ref_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DictRefAdvanced
    {
        public static void Main(string[] args)
        {
            //var for input;
            var input = Console.ReadLine();
            //dictionary for result;
            var result = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                //spliting the input;
                var token = input.Split(new char[4] {' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                //var for key;
                var key = token[0];
                //var for first value;
                int firstValue;

                //checking the input;
                if (int.TryParse(token[1], out firstValue)) 
                {
                    if (!result.ContainsKey(key))
                    {
                        result[key] = new List<int>();
                    }

                    for (int i = 1; i < token.Length; i++)
                    {
                        result[key].Add(int.Parse(token[i]));
                    }
                }
                else
                {
                    //var for second key;
                    var secondKey = token[1];
                    if (result.ContainsKey(secondKey))
                    {
                        //var for list to copy;
                        var listValue = result[secondKey];
                        result[key] = new List<int>(listValue);
                    }
                }

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var item in result)
            {
                Console.WriteLine("{0} === {1}", item.Key, string.Join(", ", item.Value));
            }
        }
    }
}
