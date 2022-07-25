using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha14
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int br2 = 0;
            int br3 = 0;
            int br5 = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) br2++;
                if (num % 3 == 0) br3++;
                if (num % 5 == 0) br5++;                
            }
            Console.WriteLine(br2);
            Console.WriteLine(br3);
            Console.WriteLine(br5);
        }
    }
}
