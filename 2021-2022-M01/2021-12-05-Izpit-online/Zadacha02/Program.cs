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
            var firstPresent = double.Parse(Console.ReadLine());

            var secondPresent = firstPresent * 0.2;
            var thirdPresent = secondPresent * 0.7;
            var fourthPresent = secondPresent * 0.5;

            var total = firstPresent + secondPresent + thirdPresent + fourthPresent;
            if (budget >= total)
                Console.WriteLine($"Yes! {budget - total:f2} leva left.");
            else
                Console.WriteLine($"No! {total - budget:f2} leva needed.");
        }
    }
}
