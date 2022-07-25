using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { -5, 5, -4, 4, -3, 3, -2, 2, -1, 1 };
            var alphas = new char[] { 'w', 'd', 't', 'g', 'n', 'm', 'a', 'b', 'c', 's', 'r', 'u', 'o', 'p', 'z', 'f', 'k' };

            Console.WriteLine("Linear Search for Number [7] ...");
            if (Search.Linear(numbers, 7) == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }

            Console.WriteLine("Linear Search for Char ['y'] ...");
            if (Search.Linear(alphas, 'y') == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }
        }
    }
}
