namespace Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RandomizeWords
    {
        public static void Main(string[] args)
        {
            //read the input and split;
            var input = Console.ReadLine().Split(' ').ToArray();

            //var for random object;
            var rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                //var for random position;
                int pos2 = rnd.Next(0, input.Length);
                //var for temp value;
                var temp = input[i];
                //swap the values;
                input[i] = input[pos2];
                input[pos2] = temp;
                
            }

            //print thr result;
            Console.WriteLine(string.Join("\n", input));
        }
    }
}
