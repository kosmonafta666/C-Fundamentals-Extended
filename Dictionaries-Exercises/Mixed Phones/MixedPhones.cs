namespace Mixed_Phones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MixedPhones
    {
        public static void Main(string[] args)
        {
            //read command for phone and name;
            var command = Console.ReadLine();

            //dictionary for phone book;
            var phoneBook = new Dictionary<string, long>();

            while (command != "Over")
            {
                //var for left command;
                var leftCommand = command.Split(new string[] {" : "}, StringSplitOptions.RemoveEmptyEntries)[0];
                //var for right operand;
                var rightCommand = command.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[1];
                //var for key for phone book;
                var key = "";
                //var for value  for phone book;
                var value = 0L;

                if (CheckOnlyDigit(leftCommand))
                {
                    key = rightCommand;
                    value = long.Parse(leftCommand);
                }
                else
                {
                    key = leftCommand;
                    value = long.Parse(rightCommand);
                }

                //fill the phone book;
                if (!phoneBook.ContainsKey(key))
                {
                    phoneBook.Add(key, value);
                }
                else
                {
                    phoneBook[key] = value;
                }

                command = Console.ReadLine();
            }//end of while loop;

            foreach (var item in phoneBook.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        //method to check if string is only digit;
        public static bool CheckOnlyDigit(string value)
        {
            return value.All(x => Char.IsDigit(x));
        }
    }
}
