using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zzdacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();

            var n = int.Parse(Console.ReadLine());

            if (numbers.Contains(n))
            {
                Console.WriteLine($"{n} Exists in the List");
            }
            else
            {
                Console.WriteLine($"{n} Not exists in the List");
            }
        }
    }
}
