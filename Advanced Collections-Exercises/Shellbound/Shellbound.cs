namespace Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Shellbound
    {
        public static void Main(string[] args)
        {
            //var for input;
            var input = Console.ReadLine();
            //dictionary for result;
            var result = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                //var for town;
                var town = input.Split(' ')[0];
                //var for shell;
                var shell = int.Parse(input.Split(' ')[1]);

                if (!result.ContainsKey(town))
                {
                    result[town] = new HashSet<int>();
                }

                result[town].Add(shell);

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var item in result)
            {
                //var for giant shell;
                var giantShell = Math.Ceiling(item.Value.Sum() - item.Value.Average());

                Console.WriteLine("{0} -> {1} ({2})", item.Key, string.Join(", ", item.Value), giantShell);
            }
        }
    }
}
