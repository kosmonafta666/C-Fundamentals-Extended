namespace Rotate_Array_of_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RotateArrayOfStrings
    {
        public static void Main(string[] args)
        {
            //read the input and splited;
            var input = Console.ReadLine().Split(' ').ToArray();

            //array for converted input;
            string[] convertInput = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                convertInput[(i + 1) % input.Length] = input[i];
            }

            Console.WriteLine(string.Join(" ", convertInput));
        }
    }
}
