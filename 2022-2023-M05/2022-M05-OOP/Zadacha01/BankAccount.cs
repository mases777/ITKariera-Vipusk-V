using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount(decimal amount = 0)
        {
            this.Balance = amount;
        }

        public void Deposit(decimal cash)
        {
            this.Balance += cash;
        }
    }
}
