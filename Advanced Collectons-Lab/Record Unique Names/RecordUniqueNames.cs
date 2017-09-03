namespace Record_Unique_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RecordUniqueNames
    {
        public static void Main(string[] args)
        {
            //var for number of student;
            var numberStudent = int.Parse(Console.ReadLine());

            //hash set for result;
            var result = new HashSet<string>();

            //add item to result;
            for (int i = 1; i <= numberStudent; i++)
            {
                //var for input;
                var input = Console.ReadLine();

                result.Add(input);
            }

            //print the result;
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
