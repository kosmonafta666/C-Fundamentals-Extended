namespace Stateless
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Stateless
    {
        public static void Main(string[] args)
        {
            //list for strings result;
            var result = new List<string>();

            //var for state string;
            var state = Console.ReadLine();

            while (state != "collapse")
            {
                //var for fiction string;
                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    state = state.Replace(fiction, string.Empty);

                    if (fiction.Length > 2)
                    {
                        fiction = fiction.Substring(1, fiction.Length - 2);
                    }
                    else
                    {
                        fiction = "";
                    }
                }//end of inner while loop;

                //add current state to result list
                result.Add(state.Trim());

                state = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var str in result)
            {
                if (str.Length > 0)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine("(void)");
                }
            }
        }   
    }
}
