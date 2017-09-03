namespace Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CitiesByContinentAndCountry
    {
        public static void Main(string[] args)
        {
            //read the number of input;
            var n = int.Parse(Console.ReadLine());

            //dicionary for result;
            var result = new Dictionary< string, Dictionary<string, List<string>> >();

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

                //fill the dictionary;
                if (!result.ContainsKey(continent))
                {
                    result[continent] = new Dictionary<string, List<string>>();
                }

                if (!result[continent].ContainsKey(country))
                {
                    result[continent][country]= new List<string>();
                }

                result[continent][country].Add(city);
            }//end of for loop;

            //print the result;
            foreach (var item in result)
            {
                //var for continent name;
                var continentName = item.Key;
                //var for country name;
                var countries = item.Value;

                Console.WriteLine("{0}:", continentName);

                foreach (var country in countries)
                {
                    Console.WriteLine("  {0} -> {1}", country.Key, string.Join(", ", country.Value));
                }
            }
        }
    }
}
