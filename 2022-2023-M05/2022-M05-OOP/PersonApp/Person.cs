using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is: {this.Name}, my age is: {this.Age}");
        }
        private List<BankAccount> accounts;

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public decimal GetBalance()
        {
            return accounts.Sum(x => x.Balance);
        }
    }
}
