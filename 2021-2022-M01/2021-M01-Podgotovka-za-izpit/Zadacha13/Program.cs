using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            var sektor = Console.ReadLine();
            var row = int.Parse(Console.ReadLine());
            var seat = int.Parse(Console.ReadLine());

            double profit = 0.0;
            switch (sektor)
            {
                case "Sector A":
                    profit = row * seat * 11.60;
                    break;
                case "Sector B":
                    profit = row * seat * 14.50;
                    break;
                case "Sector C":
                    profit = row * seat * 16.10;
                    break;
                case "Sector D":
                    profit = row * seat * 8.40;
                    break;
            }
            Console.WriteLine($"{sektor} profit is {profit:f2} lv.");
        }
    }
}
