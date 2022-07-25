using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetable = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            int kgVegetable = int.Parse(Console.ReadLine());
            int kgFruit = int.Parse(Console.ReadLine());

            double vegetable = priceVegetable * kgVegetable;
            double fruit = priceFruit * kgFruit;
            double total = (vegetable + fruit) / 1.94;

            Console.WriteLine($"{total:f2}");
        }
    }
}
