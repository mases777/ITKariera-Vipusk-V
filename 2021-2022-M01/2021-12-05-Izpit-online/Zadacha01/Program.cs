using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceLaminate = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var pricePad = double.Parse(Console.ReadLine());

            var areaRoom = width * length;
            var laminatePrice = priceLaminate * areaRoom;
            var padPrice = pricePad * areaRoom;
            var priceMontaj = 0.4 * (laminatePrice + padPrice);
            var totalPrice = laminatePrice + padPrice + priceMontaj;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
