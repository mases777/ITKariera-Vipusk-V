using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha12
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foodkg = int.Parse(Console.ReadLine());
            var deer1Food = double.Parse(Console.ReadLine());
            var deer2Food = double.Parse(Console.ReadLine());
            var deer3Food = double.Parse(Console.ReadLine());

            var neededFood = days * (deer1Food + deer2Food + deer3Food);
            if (neededFood <= foodkg)
            {
                Console.WriteLine($"{Math.Floor(foodkg - neededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(neededFood - foodkg)} more kilos of food are needed.");
            }
        }
    }
}
