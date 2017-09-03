namespace Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Batteries
    {
        public static void Main(string[] args)
        {
            //read the batteries;
            var batteries = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //read the capacity of batteries;
            var capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //read the hours of testing;
            var hours = double.Parse(Console.ReadLine());

            for (int i = 0; i < batteries.Length; i++)
            {
                //var for remaining capacity;
                var remaining = capacity[i] * hours;

                if (remaining >= batteries[i])
                {
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", (i + 1), Math.Ceiling(batteries[i] / capacity[i]));
                }
                else
                {
                    //var for remainig power in batterie;
                    var power = batteries[i] - (capacity[i] * hours);

                    //var for remaining pecent;
                    var percent = (power / batteries[i]) * 100;

                    Console.WriteLine("Battery {0}: {1:F2} mAh ({2:F2})%", (i + 1), power, percent);

                }
            }
        }
    }
}
