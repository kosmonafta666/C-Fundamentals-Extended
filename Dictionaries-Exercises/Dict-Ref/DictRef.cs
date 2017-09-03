namespace Dict_Ref
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class DicRef
    {
        public static void Main(string[] args)
        {
            //var for command;
            var command = Console.ReadLine();

            //dictionary for result;
            var result = new Dictionary<string, int>();

            while (command != "end")
            {
                //var for key;
                var key = command.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries)[0];
                //var for value;
                var value = command.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries)[1];

                //var to check if value is number;
                bool isNumber = IsNumeric(value);

                //primary check existing keys;
                if (!result.ContainsKey(key))
                {
                    //if vlaue is number;
                    if (isNumber)
                    {
                        result.Add(key, int.Parse(value));
                    }
                    else
                    {
                        //if such key existing;
                        if (result.ContainsKey(value))
                        {
                            var parsedValue = result[value];
                            result.Add(key, parsedValue);
                        }
                    }
                }//end of primary check;
                else
                {
                    //if value is number;
                    if (isNumber)
                    {
                        result[key] = int.Parse(value);
                    }
                    else
                    {
                        //if such key existing;
                        if (result.ContainsKey(value))
                        {
                            var parsedValue = (int)result[value];
                            result[key] = parsedValue;
                        }
                    }
                }//end of fill the dictionary;

                command = Console.ReadLine();
            }

            //printing the result;
            foreach (var item in result)
            {
                Console.WriteLine("{0} === {1}", item.Key, item.Value);
            }
        }

        //method to check if string is numeric;
        public static bool IsNumeric(string value)
        {
            return value.All(char.IsDigit);
        }
    }
}
