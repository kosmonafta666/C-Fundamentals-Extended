namespace Optimized_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OptimizedBankingSystem
    {
        public static void Main(string[] args)
        {
            //list for bankAccount objects;
            var accounts = new List<BankAccount>();

            //var for input;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //var for splitted input;
                var token = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                //var for name;
                var name = token[1];
                //var for bank;
                var bank = token[0];
                //var for account;
                var accountBalance = decimal.Parse(token[2]);

                //var for current bank account;
                var currentAccount = new BankAccount()
                {
                    Name = name,
                    Bank = bank,
                    Balance = accountBalance
                };

                accounts.Add(currentAccount);

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var account in accounts.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine("{0} -> {1} ({2})", account.Name, account.Balance, account.Bank);
            }
        }
    }
}
