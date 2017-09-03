namespace Power_Plants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PowerPlants
    {
        public static void Main(string[] args)
        {
            //read the flowers;
            var flowers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            //var for days;
            var days = -1;

            for (int rows = 0; rows < flowers.Length; rows++)
            {
                //if flowers is empty break;
                if (CheckArray(flowers))
                {
                    break;
                }

                //procecing the cols;
                for (int cols = 0; cols < flowers.Length; cols++)
                {
                    if (flowers[cols] != 0 && cols != rows)
                    {
                        flowers[cols]--;
                    }
                }

                days++;

                //if flowers is not empty and season is end incease the value of flowers
                //and resume the for loop;
                if (!CheckArray(flowers))
                {
                    if (rows == flowers.Length - 1)
                    {
                        for (int k = 0; k < flowers.Length; k++)
                        {
                            if (flowers[k] > 0)
                            {
                                flowers[k]++;
                            }
                            rows = -1;
                        }
                    }
                }
       
            }

            Console.WriteLine("survived {0} days ({1} seasons)", days + 1, days / flowers.Length);
        }

        //method to check if array is fill with zero;
        public static bool CheckArray(long[] array)
        {
            bool hasOnlyZeroes = array.All(x => x == 0);

            return hasOnlyZeroes;
        }
    }
}

