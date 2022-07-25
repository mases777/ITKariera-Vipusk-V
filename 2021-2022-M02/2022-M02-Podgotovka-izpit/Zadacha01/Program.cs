using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "treadmill":
                        sum += 5899; break;
                    case "cross trainer":
                        sum += 1699; break;
                    case "exercise bike":
                        sum += 1789; break;
                    case "dumbbells":
                        sum += 579; break;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
