using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchebna_zala
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine()) * 100.0;
            var w = double.Parse(Console.ReadLine()) * 100.0;

            var row = Math.Floor(h / 120);
            var col = Math.Floor((w - 100) / 70);

            Console.WriteLine(row * col - 3);
        }
    }
}
