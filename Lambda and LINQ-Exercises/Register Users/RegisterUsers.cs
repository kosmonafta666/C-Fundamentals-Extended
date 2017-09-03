namespace Register_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class RegisterUsers
    {
        public static void Main(string[] args)
        {
            //dictionary for result;
            var userDict = new Dictionary<string, DateTime>();

            //var for input;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //var for splited input;
                var token = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                //var for key;
                var user = token[0];
                //var for value;
                var date = DateTime.ParseExact(token[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                //fill the dictionary;
                if (!userDict.ContainsKey(user))
                {
                    userDict.Add(user, date);
                }
                else
                {
                    userDict[user] = date;
                }

                input = Console.ReadLine();
            }//end of while loop;

            var sortedDict = userDict.Reverse().OrderBy(x => x.Value).Take(5);

            foreach (var item in sortedDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0}", item.Key);
            }
        }
    }
}
