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
            var neoni = int.Parse(Console.ReadLine());
            var molinezii = int.Parse(Console.ReadLine());
            var heleri = int.Parse(Console.ReadLine());
                        
            var water = neoni * 4 + (molinezii + heleri) * 8;

            Console.WriteLine(water);
        }
    }
}
