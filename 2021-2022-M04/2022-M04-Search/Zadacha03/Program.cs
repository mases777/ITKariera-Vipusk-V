using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { -5, 5, -4, 4, -3, 3, -2, 2, -1, 1 };
            var alphas = new char[] { 'w', 'd', 't', 'g', 'n', 'm', 'a', 'b', 'c', 's', 'r', 'u', 'o', 'p', 'z', 'f', 'k' };

            numbers = numbers.OrderBy(x => x).ToArray();
            alphas = alphas.OrderBy(x => x).ToArray();


            Console.WriteLine("Binary Search for Number [7] ...");
            if (Search.InterpolationSearch(numbers, 7) == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }

            //Console.WriteLine("Binary Search for Char ['z'] ...");
            //if (Search.InterpolationSearch(alphas, 'z') == -1)
            //{
            //    Console.WriteLine("Not Found");
            //}
            //else
            //{
            //    Console.WriteLine("Found");
            //}

        }
    }
}
