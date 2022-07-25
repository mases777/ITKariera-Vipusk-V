using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            var perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Area = {area:f2}");
            Console.WriteLine($"Perimeter = {perimeter:f2}");
        }
    }
}
