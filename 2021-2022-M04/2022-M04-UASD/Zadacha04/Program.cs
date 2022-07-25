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
            var nums = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToList();

            Console.WriteLine($"Sum = {nums.Sum()}; Average = {nums.Average():f2}");
        }
    }
}
