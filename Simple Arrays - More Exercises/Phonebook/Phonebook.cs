namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Phonebook
    {
        public static void Main(string[] args)
        {
            //read the numbers and split;
            var numbers = Console.ReadLine().Split(' ').ToArray();

            //read the names and split;
            var names = Console.ReadLine().Split(' ').ToArray();

            //var for read the commands;
            var command = Console.ReadLine();

            while (command != "done")
            {
                //var for index of the name;
                var indexName = Array.IndexOf(names, command);

                Console.WriteLine("{0} -> {1}", command, numbers[indexName]);

                command = Console.ReadLine();
            }
        }
    }
}
