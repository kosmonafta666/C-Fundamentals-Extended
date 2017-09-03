namespace Exam_Shopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class ExamShopping
    {
        public static void Main(string[] args)
        {
            //dictionary for inventory;
            var inventory = new Dictionary<string, long>();

            while (true)
            {
                var loading = Console.ReadLine();

                if (loading == "shopping time")
                {
                    break;
                }

                //var for stocks;
                var stocks = loading.Split((new [] {' '}), StringSplitOptions.RemoveEmptyEntries).ToArray();
                //var for stock;
                var stock = stocks[1];
                //var for quantity of stock;
                var quantity = 0L;

                var parsed = long.TryParse(stocks[2], out quantity);

                //fill the inventory;
                if (!inventory.ContainsKey(stock))
                {
                    inventory.Add(stock, 0);
                }

                inventory[stock] += quantity;

            }//end of first while loop;


            while (true)
            {
                var shoping = Console.ReadLine();

                if (shoping == "exam time")
                {
                    break;
                }

                //var for bying;
                var bying = shoping.Split((new[] { ' ' }), StringSplitOptions.RemoveEmptyEntries).ToArray();
                //var for stock to buy;
                var stock = bying[1];
                //var for quiantity to buy;
                var quantity = 0L;

                var parsed = long.TryParse(bying[2], out quantity);

                if (!inventory.ContainsKey(stock))
                {
                    Console.WriteLine("{0} doesn't exist", stock);
                }
                else
                {
                    if (inventory[stock] <= 0)
                    {
                        Console.WriteLine("{0} out of stock", stock);
                    }
                    else
                    {
                        inventory[stock] -= quantity;
                    }
                }
            }//enf of seconfd while loop;

            foreach (var item in inventory)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
            }
        }
    }
}
