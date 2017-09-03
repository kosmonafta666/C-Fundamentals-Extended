namespace Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Websites
    {
        public static void Main(string[] args)
        {
            //list for websites object;
            var websites = new List<Website>();

            //var for input;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //var for splitted input;
                var token = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                //var for current website object;
                var currentWebsite = new Website
                {
                    Host = "",
                    Domain = "",
                    Queries = new List<string>()
                };

                //var for host;
                var host = token[0];
                currentWebsite.Host = host;

                //var for domain;
                var domain = token[1];
                currentWebsite.Domain = domain;

                //check if have any queries;
                if (token.Length > 2)
                {
                    //var for queries;
                    var queries = token[2].Split(',').ToArray();
                    //fill the qieries of the current website;
                    foreach (var query in queries)
                    {
                        currentWebsite.Queries.Add(query);
                    }
                }//end of check;
                    
                //add the current website to list of websites;
                websites.Add(currentWebsite);

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var website in websites)
            {
                Console.Write("https://www.{0}.", website.Host);
                Console.Write("{0}", website.Domain);

                if (website.Queries.Count > 0)
                {
                    Console.Write("/query?=");

                    foreach (var query in website.Queries)
                    {
                        //var for last query;
                        var lastQuery = website.Queries.Last();

                        if (query == lastQuery) {
                            Console.Write("[{0}]", query);
                        }
                        else
                        {
                            Console.Write("[{0}]&", query);
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
