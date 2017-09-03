namespace Array_Symmetry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArraySymmetry
    {
        public static void Main(string[] args)
        {
            //read the input,split and convert to string array;
            var input = Console.ReadLine().Split(' ').ToArray();

            //bool for check if strings are equal;
            bool flag = true;

            for (int i = 0; i < input.Length / 2; i++)
            {
                //var for left string
                var leftString = input[i];

                //var for right string;
                var rightString = input[(input.Length - 1) - i];

                if (leftString != rightString)
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
