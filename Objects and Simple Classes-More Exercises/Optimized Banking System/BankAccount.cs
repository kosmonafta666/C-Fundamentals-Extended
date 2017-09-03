namespace Optimized_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BankAccount
    {
        private string name;
        private string bank;
        private decimal balance;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Bank
        {
            get { return bank; }
            set { bank = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
     }
}
