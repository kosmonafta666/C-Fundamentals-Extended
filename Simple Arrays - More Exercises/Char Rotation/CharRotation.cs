namespace Char_Rotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CharRotation
    {
        public static void Main(string[] args)
        {
            //read the char array;
            var charArray = Console.ReadLine().ToCharArray();

            //read the integer array;
            var intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    Console.Write((char)(charArray[i] - intArray[i]));
                }
                else if (intArray[i] % 2 != 0)
                {
                    Console.Write((char)(charArray[i] + intArray[i]));
                }
            }

            Console.WriteLine();
        }
    }
}
