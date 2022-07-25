using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceRaketa = double.Parse(Console.ReadLine());
            var broiRaketi = int.Parse(Console.ReadLine());
            var broiMaratonki = int.Parse(Console.ReadLine());

            var cenaRaketi = priceRaketa * broiRaketi;
            var cenaMaratonki = priceRaketa / 6.0;
            var obshtaCenaMaratonki = broiMaratonki * cenaMaratonki;
            var cenaOborudvane = (cenaRaketi + obshtaCenaMaratonki) * 0.2;
            var obshtaCena = cenaRaketi + obshtaCenaMaratonki + cenaOborudvane;
            var cenaDjokovic = obshtaCena / 8.0;
            var cenaSponsori = obshtaCena - cenaDjokovic;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(cenaDjokovic)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(cenaSponsori)}");
        }
    }
}
