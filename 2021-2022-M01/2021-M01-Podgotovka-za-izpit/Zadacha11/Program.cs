using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha11
{
    class Program
    {
        static void Main(string[] args)
        {
            var averageSpeed = double.Parse(Console.ReadLine());
            var fuel100 = double.Parse(Console.ReadLine());

            int lenth = 768800;
            var time = Math.Ceiling(lenth / averageSpeed) + 3;
            var fuel = (fuel100 * lenth) / 100.0;

            Console.WriteLine(time);
            Console.WriteLine(fuel);
        }
    }
}
