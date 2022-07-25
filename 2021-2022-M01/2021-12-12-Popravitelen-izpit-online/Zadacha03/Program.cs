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
            var paketCount = int.Parse(Console.ReadLine());
            var tea = Console.ReadLine();            
            var nameDostav = Console.ReadLine();

            double total = 0;
            if (tea == "HerbsTea")
            {
                if (nameDostav == "Teahouse") total = paketCount * 3.0;
                else if (nameDostav == "Leaf") total = paketCount * 5.0;
                else total = paketCount * 4.0;
            }
            else if (tea == "BlackTea")
            {
                if (nameDostav == "Teahouse") total = paketCount * 5.0;
                else if (nameDostav == "Leaf") total = paketCount * 8.0;
                else total = paketCount * 10.0;
            }
            else
            {
                if (nameDostav == "Teahouse") total = paketCount * 4.5;
                else if (nameDostav == "Leaf") total = paketCount * 7.0;
                else total = paketCount * 9.5;
            }

            Console.WriteLine($"{total:f2}");
        }
    }
}
