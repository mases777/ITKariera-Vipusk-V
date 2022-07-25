using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Box box = new Box(lenght, width, height);
            Console.WriteLine($"Surface Area – {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume – {box.Volume():f2}");
        }
    }
}
