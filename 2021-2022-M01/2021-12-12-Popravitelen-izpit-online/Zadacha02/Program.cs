using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var bookPrice = double.Parse(Console.ReadLine());

            var clothes = bookPrice * 0.2;
            var cosmetics = bookPrice * 0.05;
            var razhodi = bookPrice * 0.12;

            var total = bookPrice + clothes + cosmetics + razhodi;
            if (budget >= total)
                Console.WriteLine($"Yes! {budget - total:f2} leva left.");
            else
                Console.WriteLine($"No! {total - budget:f2} leva needed.");
        }
    }
}
