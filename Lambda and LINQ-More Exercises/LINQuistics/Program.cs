namespace LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            //dictioany for result;
            var result = new Dictionary<string, HashSet<string>>();

            //var for input;
            var input = Console.ReadLine();

            while (input != "exit")
            {
                //var for splited input;
                var token = input.Split(new[] { '.', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //var for number to print methods;
                var methodCount = 0;

                if (token.Length > 1)
                {
                    //var for collection;
                    var collection = token[0];
                    //fill the dictionary;
                    if (!result.ContainsKey(collection))
                    {
                        result.Add(collection, new HashSet<string>());
                    }

                    for (int i = 1; i < token.Length; i++)
                    {
                        result[collection].Add(token[i]);
                    }
                }
                else
                {
                    try
                    {
                        if (!Int32.TryParse(token[0], out methodCount))
                        {
                            if (result.ContainsKey(token[0]))
                            {
                                //sorted list by value lenght;
                                var sortedMethods = result[token[0]]
                                                    .OrderByDescending(x => x.Length)
                                                    .ThenByDescending(x => x.Distinct().Count())
                                                    .ToList();

                                sortedMethods.ForEach(x => Console.WriteLine("* {0}", x));

                            }
                        }
                        else if (Int32.TryParse(token[0], out methodCount))
                        {
                            //list for collection with most methods;
                            var mostMethods = result.Values
                                                .OrderByDescending(x => x.Count())
                                                .First()
                                                .OrderBy(x => x.Length)
                                                .Take(methodCount)
                                                .ToList();

                            mostMethods.ForEach(x => Console.WriteLine("* {0}", x));
                        }
                    }
                    catch
                    {

                    }
                }


                input = Console.ReadLine();
            }//end of while loop;

            //var for method and selection;
            var commandLine = Console.ReadLine().Split(' ');
            //var for method ;
            var method = commandLine[0];
            //var for selectio;
            var selection = commandLine[1];

            if (selection == "all")
            {
                var sortedCollections = result.Where(x => x.Value.Contains(method))
                                              .OrderByDescending(x => x.Value.Count)
                                              .ThenByDescending(x => x.Value.Min(y => y.Length));

                foreach (var item in sortedCollections)
                {
                    Console.WriteLine(item.Key);

                    foreach (var value in item.Value.OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine("* {0}", value);
                    }
                }
            }
            else if (selection == "collection")
            {
                var sortedCollections = result.Where(x => x.Value.Contains(method))
                                              .OrderByDescending(x => x.Value.Count)
                                              .ThenByDescending(x => x.Value.Min(y => y.Length));

                foreach (var item in sortedCollections)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
