using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    class Program
    {
        static void Main(string[] args)
        {
            int tour = int.Parse(Console.ReadLine());
            int startPoint = int.Parse(Console.ReadLine());
            int totalPoint = 0;
            var averagePoint = 0.0;
            var averagePercent = 0.0;
            int count = 0;

            for (int i = 1; i <= tour; i++)
            {
                var etap = Console.ReadLine();
                if (etap == "W") { totalPoint += 2000; count++; }
                else if (etap == "F") totalPoint += 1200;
                else totalPoint += 720;
            }
            averagePoint = (double)totalPoint / tour;
            averagePercent = (double)count / tour * 100;

            Console.WriteLine($"Final points: {startPoint + totalPoint}");
            Console.WriteLine($"Average points: {Math.Truncate(averagePoint)}");
            Console.WriteLine($"{averagePercent:F2}%");

        }
    }
}
