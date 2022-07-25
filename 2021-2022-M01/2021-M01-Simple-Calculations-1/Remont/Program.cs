using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remont
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());

            var area = n * n;
            var bench = m * o;
            area = area - bench;
            var pl = w * l;
            var needed = area / pl;
            var time = needed * 0.2;

            Console.WriteLine($"{needed:f2}");
            Console.WriteLine($"{time:f2}");

        }
    }
}
