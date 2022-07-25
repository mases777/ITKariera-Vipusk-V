using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write('+');
            Console.Write(new string('-', n-2));
            Console.WriteLine('+');

            for (int i = 0; i < n-2; i++)
            {
                Console.Write('|');
                Console.Write(new string('-', n - 2));
                Console.WriteLine('|');
            }

            Console.Write('+');
            Console.Write(new string('-', n - 2));
            Console.WriteLine('+');
        }
    }
}
