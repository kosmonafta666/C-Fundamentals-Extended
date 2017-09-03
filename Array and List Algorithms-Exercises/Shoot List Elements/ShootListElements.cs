namespace Shoot_List_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ShootListElements
    {
        public static void Main(string[] args)
        {
            //list for the result;
            var result = new List<int>();

            //var commands;
            var command = Console.ReadLine();
            //var for last index;
            var lastIndex = 0;
            //var for average sum;
            var average = 0.0;
            //bool for extra stop;
            bool stop = false;

            while (command != "stop")
            {
                //var for shoot elemant;
                int valueShoot;

                //check the type of the command;
                if (int.TryParse(command, out valueShoot))
                {
                    result.Insert(0, valueShoot);
                }
                else if (command == "bang")
                {
                    //check for condition of the list;
                    if (result.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}", lastIndex);
                        stop = true;
                        break;
                    }
                    else if (result.Count == 1)
                    {
                        //asign last index;
                        lastIndex = result.Last();
                        //asign average sum;
                        average = result.Average();
                        //remove the last element;
                        result = RemoveTheElements(average, result);
                    }
                    else
                    {
                        //asign the average sum;
                        average = result.Average();
                        //remove the elements;
                        result = RemoveTheElements(average, result);
                        //decrement the elements;
                        result = DecrementValues(result);
                        //asign the last index;
                        lastIndex = result.Last();
                    }//end of check condition of the list;
                }//end of check fro type of the command;

                command = Console.ReadLine();
            }

            //check what to print;
            if (!result.Any() && stop == false)
            {
                Console.WriteLine("you shot them all. last one was {0}", lastIndex);
            }
            else if (result.Any())
            {
                Console.WriteLine("survivors: {0}", string.Join(" ",result));
            }//end of print;
            
        }

        //method to remove the first element smaller than average;
        public static List<int> RemoveTheElements(double average, List<int> list)
        {
            //list for the result;
            var result = list;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= average)
                {
                    Console.WriteLine("shot {0}", list[i]);
                    list.Remove(list[i]);
                    break;
                }
            }

            return result;
        }

        public static List<int> DecrementValues(List<int> list)
        {
            //list for the result;
            var result = list;

            for (int i = 0; i < list.Count; i++)
            {
                list[i]--;
            }

            return result;
        }
    }
}
