namespace Count_of_Given_Element_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CountOfGivenElementInArray
    {
        static void Main(string[] args)
        {
            //read the input and split into array;
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //read the match number;
            var matchNumber = double.Parse(Console.ReadLine());
            
            //var count of match numbers;
            var countMatch = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == matchNumber)
                {
                    countMatch++;
                }
            }

            Console.WriteLine(countMatch);
        }
    }
}
