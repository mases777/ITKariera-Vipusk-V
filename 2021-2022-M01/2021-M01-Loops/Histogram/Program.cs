using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200) p1++;
                else if (num < 400) p2++;
                else if (num < 600) p3++;
                else if (num < 800) p4++;
                else p5++;                
            }
            var p1Percent = (double)p1 / n * 100.0;
            var p2Percent = (double)p2 / n * 100.0;
            var p3Percent = (double)p3 / n * 100.0;
            var p4Percent = (double)p4 / n * 100.0;
            var p5Percent = (double)p5 / n * 100.0;
            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
            Console.WriteLine($"{p4Percent:f2}%");
            Console.WriteLine($"{p5Percent:f2}%");
        }
    }
}
