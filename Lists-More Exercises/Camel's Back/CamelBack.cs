namespace Camel_s_Back
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CamelBack
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to list;
            var input = Console.ReadLine().Split(' ').ToList();

            //read the camel back;
            var camelBack = int.Parse(Console.ReadLine());

            //var for rounds;
            var rounds = 0;

            //check if already stable;
            if (input.Count == camelBack)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", input));
            }
            else
            {
                while (true)
                {
                    //remove the first element;
                    input.RemoveAt(0);
                    //remove the last element;
                    input.RemoveAt(input.Count - 1);
                    //increase the round;
                    rounds++;

                    //break if already stable;
                    if (input.Count == camelBack)
                    {
                        break;
                    }
                }

                Console.WriteLine("{0} rounds", rounds);
                Console.WriteLine("remaining: {0}", string.Join(" ", input));
            }
        }
    }
}
