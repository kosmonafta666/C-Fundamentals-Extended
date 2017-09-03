namespace Rabbit_Hole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RabbitHole
    {
        public static void Main(string[] args)
        {
            //read the input, split the array and convert to list;
            var input = Console.ReadLine().Split(' ').ToList();

            //read the energy;
            var energy = int.Parse(Console.ReadLine());

            //var for index of rabbit hole;
            var rabbitHole = input.IndexOf("RabbitHole");

            //var current index;
            int index = 0;

            //bool for bomb;
            bool bomb = false;

            while (energy > 0)
            {
                //spit the current input;
                var currentCommand = input[index].Split('|').ToArray();

                //if we are at the rabbit hole, print the result and break;
                if (currentCommand[0] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }

                //parsing the right command;
                int value = int.Parse(currentCommand[1]);

                switch (currentCommand[0])
                {
                    case "Left":
                        index = Math.Abs(index - value) % input.Count;
                        energy -= value;
                        break;
                    case "Right":
                        index = (index + value) % input.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        input.RemoveAt(index);
                        energy -= value;
                        index = 0;
                        bomb = true;
                        break;
                }//end of switch check;

                //adding the bomb command in the end of the input list;
                if (input[input.Count - 1] != "RabbitHole")
                {
                    input.RemoveAt(input.Count - 1);
                }

                input.Add("Bomb|" + energy);

                //printing the result;
                if (energy <= 0 && bomb)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                }
                else if (energy <= 0)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }

            }//end of while loop;
        }
    }
}
