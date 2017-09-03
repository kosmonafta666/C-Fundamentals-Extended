namespace Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SalesReport
    {
        public static void Main(string[] args)
        {
            //read the number of sales;
            var numberOfSales = int.Parse(Console.ReadLine());

            //list for sales;
            var sales = new List<Sale>();

            for (int i = 1; i <= numberOfSales; i++)
            {
                //var for commands;
                var commands = Console.ReadLine().Split(' ').ToArray();

                //var for current sale;
                var currentSale = ReadSale(commands[0], commands[1], decimal.Parse(commands[2]), decimal.Parse(commands[3]));

                //add a current sale to list of sales;
                sales.Add(currentSale);
            }//end of for loop;

            foreach (var town in sales.Select(x => x.Town).Distinct().OrderBy(x => x)) 
            {
                //var sum of current town;
                decimal sum = 0.0m;

                Console.Write("{0} -> ", town);

                //var for current town;
                var currentTown = sales.Where(x => x.Town == town);

                foreach (var sale in currentTown)
                {
                    sum += sale.Price * sale.Quantity;
                }

                Console.WriteLine("{0:F2}", sum);
            }
        }

        //method to read data and return Sale object;
        public static Sale ReadSale(string town, string product, decimal price, decimal quantity)
        {
            //var for Sale object;
            var sale = new Sale()
            {
                Town = town,
                Product = product,
                Price = price,
                Quantity = quantity
            };

            return sale;
        }
    }
}
