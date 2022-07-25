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
            var earthquakes = int.Parse(Console.ReadLine());

            int light = 0, moderate = 0, strong = 0, veryStrong = 0;
            for (int i = 0; i < earthquakes; i++)
            {
                var strength = double.Parse(Console.ReadLine());
                if (strength > 7) veryStrong++;
                else if (strength > 6) strong++;
                else if (strength > 4) moderate++;
                else light++;
            }

            Console.WriteLine($"Light: {(double)light / earthquakes * 100:f2}%");
            Console.WriteLine($"Moderate: {(double)moderate / earthquakes * 100:f2}%");
            Console.WriteLine($"Strong: {(double)strong / earthquakes * 100:f2}%");
            Console.WriteLine($"Very Strong: {(double)veryStrong / earthquakes * 100:f2}%");
        }
    }
}
