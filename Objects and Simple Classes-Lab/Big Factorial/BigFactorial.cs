namespace Big_Factorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main(string[] args)
        {
            //read the number and parse to integer;
            var number = int.Parse(Console.ReadLine());

            //var for result;
            BigInteger result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            //print the result;
            Console.WriteLine(result);
        }
    }
}
