using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            var priceBitcoins = bitcoins * 1168;
            var priceYuan = yuan * 0.15 * 1.76;
            var priceEuro = (priceBitcoins + priceYuan) / 1.95;
            var taxEuro = priceEuro * tax / 100.0;

            Console.WriteLine($"{(priceEuro - taxEuro):f2}");

        }
    }
}
