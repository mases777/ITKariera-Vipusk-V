using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    class Program
    {
        static void Main(string[] args)
        {
            var etap = Console.ReadLine();
            var vid = Console.ReadLine();
            var broiBileti = int.Parse(Console.ReadLine());
            var snimka = char.Parse(Console.ReadLine());

            var cenaBileti = 0.0;
            if (vid == "Standard")
            {
                if (etap == "Quarter final") cenaBileti = broiBileti * 55.50;
                else if (etap == "Semi final") cenaBileti = broiBileti * 75.88;
                else if (etap == "Final") cenaBileti = broiBileti * 110.10;
            }
            else if (vid == "Premium")
            {
                if (etap == "Quarter final") cenaBileti = broiBileti * 105.20;
                else if (etap == "Semi final") cenaBileti = broiBileti * 125.22;
                else if (etap == "Final") cenaBileti = broiBileti * 160.66;
            }
            else if (vid == "VIP")
            {
                if (etap == "Quarter final") cenaBileti = broiBileti * 118.90;
                else if (etap == "Semi final") cenaBileti = broiBileti * 300.40;
                else if (etap == "Final") cenaBileti = broiBileti * 400.0;
            }
            if (snimka == 'Y' && cenaBileti <= 4000)
            {
                cenaBileti += 40 * broiBileti;
            }
            if (cenaBileti > 4000)
            {
                cenaBileti -= cenaBileti / 4.0;
            }
            else if (cenaBileti > 2500)
            {
                cenaBileti -= cenaBileti / 10.0;
            }
            Console.WriteLine($"{cenaBileti:f2}");
        }
    }
}
