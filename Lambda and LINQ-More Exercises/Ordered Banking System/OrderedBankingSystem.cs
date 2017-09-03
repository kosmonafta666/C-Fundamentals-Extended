namespace Ordered_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderedBankingSystem
    {
        public static void Main(string[] args)
        {
            //dictionary for result;
            var result = new Dictionary<string, Dictionary<string, decimal>>();

            //var for input;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //var for splited input;
                var token = input.Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                //var for bank;
                var bank = token[0];
                //var for bank account;
                var bankAccount = token[1];
                //var for ballance;
                var balance = decimal.Parse(token[2]);

                //fill the dictionary;
                if (!result.ContainsKey(bank))
                {
                    result.Add(bank, new Dictionary<string,decimal>());
                }

                if (!result[bank].ContainsKey(bankAccount))
                {
                    result[bank].Add(bankAccount, balance);
                }
                else
                {
                    result[bank][bankAccount] += balance;
                }

                input = Console.ReadLine();
            }//end of while loop;

            //printig the result;
            result
                .OrderByDescending(bank => bank.Value.Sum(balance => balance.Value))
                .ThenByDescending(bank => bank.Value.Max(balance => balance.Value))
                .ToList()
                .ForEach(bank => bank.Value
                .OrderByDescending(balance => balance.Value)
                .ToList()
                .ForEach(balance => Console.WriteLine("{0} -> {1} ({2})", balance.Key, balance.Value, bank.Key)));
        }
    }
}
