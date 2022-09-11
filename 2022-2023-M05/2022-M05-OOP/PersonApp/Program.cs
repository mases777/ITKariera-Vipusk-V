using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Ivan";
            firstPerson.Age = 15;
            firstPerson.IntroduceYourself();
            firstPerson.Accounts = new List<BankAccount>()
            {
                new BankAccount() {Id = 1, Balance = 100},
                new BankAccount() {Id = 2, Balance = 200},
                new BankAccount() {Id = 3, Balance = 300}
            };

            Console.WriteLine($"Balance = {firstPerson.GetBalance()}");

            //Person secondPerson = new Person();
            //secondPerson.Name = Console.ReadLine();
            //secondPerson.Age = int.Parse(Console.ReadLine());
            //secondPerson.IntroduceYourself();

            Console.WriteLine(Arithmetics.Add(10, 15));
            Console.WriteLine(Arithmetics.Multiply(10, 15));

        }
    }
}
