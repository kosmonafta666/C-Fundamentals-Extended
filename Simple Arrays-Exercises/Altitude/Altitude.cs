namespace Altitude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Altitude
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to string array;
            var input = Console.ReadLine().Split(' ').ToArray();

            //var for altitude;
            var altitude = double.Parse(input[0]);

            //array for commands;
            var commands = new string[input.Length - 1];

            //fill the commands array;
            for (int i = 1; i < input.Length; i++)
            {
                commands[i - 1] = input[i];
            }

            //Console.WriteLine(string.Join(" ", commands));

            for (int i = 0; i < commands.Length - 1; i += 2)
            {
                //var command;
                var command = commands[i];

                //var for altitude of the command;
                var height = commands[i + 1];

                if (command == "up")
                {
                    altitude += double.Parse(height);
                }
                else if (command == "down")
                {
                    altitude -= double.Parse(height);
                }
            }

            if (altitude > 0)
            {
                Console.WriteLine("got through safely. current altitude: {0}m", altitude);
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
