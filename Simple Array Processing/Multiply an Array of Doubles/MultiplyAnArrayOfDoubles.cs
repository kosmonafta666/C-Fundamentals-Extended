namespace Multiply_an_Array_of_Doubles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MultiplyAnArrayOfDoubles
    {
        static void Main(string[] args)
        {
            //read the input , split and convert double array;
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //read the multiplying number;
            var power = double.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                //var for multiplying the current input[index];
                var multiNumber = input[i] * power;

                Console.Write("{0} ", multiNumber);
            }

            Console.WriteLine();
        }
    }
}
