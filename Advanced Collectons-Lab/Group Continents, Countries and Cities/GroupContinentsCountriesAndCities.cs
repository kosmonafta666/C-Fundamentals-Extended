namespace Group_Continents__Countries_and_Cities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GroupContinentsCountriesAndCities
    {
        public static void Main(string[] args)
        {
            //var for number of inputs:
            var n = int.Parse(Console.ReadLine());

            //sorted dictionary for result;
            var result = new SortedDictionary< string, SortedDictionary<string, SortedSet<string>> >();

            for (int i = 1; i <= n; i++)
            {
                //var for input;
                var input = Console.ReadLine().Split(' ').ToArray();
                //var for continent;
                var continent = input[0];
                //var for country;
                var country = input[1];
                //var for city;
                var city = input[2];

                //fill the result dictionary;
                if (!result.ContainsKey(continent))
                {
                    result[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!result[continent].ContainsKey(country))
                {
                    result[continent][country] = new SortedSet<string>();
                }

                result[continent][country].Add(city);

            }//end of for loop;

            //print the result;
            foreach (var item in result)
            {
                //var for continent name;
                var continentName = item.Key;
                //var for values in continent;
                var continentEnitity = item.Value;

                Console.WriteLine("{0}:", continentName);

                foreach (var country in continentEnitity)
                {
                    Console.WriteLine("  {0} -> {1}", country.Key, string.Join(", ", country.Value));
                }
            }
        }
    }
}
