using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc = new BankAccount();

            acc.Id = 1;
            acc.Balance = 15;
            //Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
            Console.WriteLine(acc);
            acc.Deposit(20);
            Console.WriteLine(acc);
            acc.Withdraw(50);
            Console.WriteLine(acc);
        }
    }
}
