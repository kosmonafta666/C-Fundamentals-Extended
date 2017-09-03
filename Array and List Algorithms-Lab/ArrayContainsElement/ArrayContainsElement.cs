namespace ArrayContainsElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayContainsElement
    {
        public static void Main(string[] args)
        {
            //read the input,spit and convert to list;
            var input = Console.ReadLine().Split(' ').ToList();

            //read the match match element;
            var matchElement = Console.ReadLine();

            //bool for match elemnet;
            bool flag = false;

            //if match element is found break;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == matchElement)
                {
                    flag = true;
                    break;
                }
            }

            //check for value of the flag;
            if (flag)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
