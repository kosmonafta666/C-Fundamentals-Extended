namespace Forum_Topics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ForumTopics
    {
        public static void Main(string[] args)
        {
            //dictionary for result;
            var result = new Dictionary<string, HashSet<string>>();

            //read the input;
            var input = Console.ReadLine();

            while(input != "filter") 
            {
                //var for splited input;
                var token = input.Split(new char[4] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                //var for post;
                var post = token[0];

                //fill the dictionary result;
                if (!result.ContainsKey(post)) 
                {
                    result[post] = new HashSet<string>();
                }

                for (int i = 1; i < token.Length; i++) 
                {
                    result[post].Add(token[i]);
                }

                input = Console.ReadLine();
            }//end of while loop;

            //var for filter command;
            var filterCommand = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //print the result;
            foreach (var item in result)
            {
                if (CheckTags(filterCommand, item.Value))
                {
                    Console.WriteLine("{0} | {1}", item.Key, string.Join(", ", item.Value.Select(x => "#" + x)));
                }
            }
        }

        //method to check if tags in filter command are in list;
        public static bool CheckTags(string[] filter, HashSet<string> tags) 
        {
            //bool for flag;
            bool flag = true;

            for (int i = 0; i < filter.Length; i++) 
            {
                if (!tags.Contains(filter[i]))
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
    }
}
