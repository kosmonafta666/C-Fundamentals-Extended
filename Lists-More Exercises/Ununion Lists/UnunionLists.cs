namespace Ununion_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UnunionLists
    {
        public static void Main(string[] args)
        {
            //read the primal list;
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //read the counto of sub lists;
            var count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                //read the sub list;
                var subList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < subList.Count; j++)
                {
                    //var for current value of sub list;
                    var currentValue = subList[j];

                    //check if current value exist in primal remove it
                    //else add to primal list;
                    if (primalList.Contains(currentValue))
                    {
                        primalList.RemoveAll( x => x == currentValue);
                    }
                    else
                    {
                        primalList.Add(currentValue);
                    }
                }
            }

            //sort the primal list;
            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
