namespace CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CottageScraper
    {
        public static void Main(string[] args)
        {
            //var for input;
            var input = Console.ReadLine();

            //dictionary for logs;
            var logsDict = new Dictionary<string, List<decimal>>();

            //var for input count;
            var inputCount = 0;

            while(input != "chop chop") 
            {
                //var for splited input;
                var token = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                //var for key;
                var key = token[0];
                //var for value;
                var value = decimal.Parse(token[1]);

                //fill the dictionary;
                if (!logsDict.ContainsKey(key))
                {
                    logsDict[key] = new List<decimal>();
                }

                logsDict[key].Add(value);

                inputCount++;

                input = Console.ReadLine();
            }//end of while loop;

            //var for type of tree;
            var typeTree = Console.ReadLine();
            //var for min length;
            var minLength = decimal.Parse(Console.ReadLine());

            //var for price per meter;
            var pricePerMeter = Math.Round((logsDict.SelectMany(x => x.Value).Sum() / inputCount), 2);

            //var for used log price;
            var usedLogsPrice = Math.Round(logsDict
                            .Where(x => x.Key == typeTree)
                            .SelectMany(x => x.Value)
                            .Where(x => x >= minLength)
                            .Sum() * pricePerMeter, 2);

            //var for unused log price(substract used logs from all logs in metters);
            var unusedLogsPrice = Math.Round( ( logsDict.SelectMany(x => x.Value).Sum() - logsDict.Where(x => x.Key == typeTree)
                                                                                            .SelectMany(x => x.Value)
                                                                                            .Where(x => x >= minLength)
                                                                                            .Sum() ) * pricePerMeter * 0.25m, 2);

            //printing the results;
            Console.WriteLine("Price per meter: ${0:F2}", pricePerMeter);
            Console.WriteLine("Used logs price: ${0:F2}", usedLogsPrice);
            Console.WriteLine("Unused logs price: ${0:F2}", unusedLogsPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:F2}", Math.Round(usedLogsPrice + unusedLogsPrice, 2));
        }
    }
}
