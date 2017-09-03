namespace Ballistics_Training
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BallisticsTraining
    {
        public static void Main(string[] args)
        {
            //read the x and y coordinates;
            var target = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //read the commands
            var commands = Console.ReadLine().Split(' ').ToArray();

            //var for shooting x;
            var shootingX = 0.0;

            //var for shooting Y;
            var shootingY = 0.0;

            for (int i = 0; i < commands.Length - 1; i += 2)
            {
                switch (commands[i])
                {
                    case "up":
                        shootingY += double.Parse(commands[i + 1]);
                        break;
                    case "down":
                        shootingY -= double.Parse(commands[i + 1]);
                        break;
                    case "left":
                        shootingX -= double.Parse(commands[i + 1]);
                        break;
                    case "right":
                        shootingX += double.Parse(commands[i + 1]);
                        break;
                }
            }

            if (shootingX == target[0] && shootingY == target[1])
            {
                Console.WriteLine("firing at [{0}, {1}]", shootingX, shootingY);
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("firing at [{0}, {1}]", shootingX, shootingY);
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
