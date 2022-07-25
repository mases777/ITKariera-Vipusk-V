using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 9, -9, 8, -8, 7, -7, 6, -6, 5, -5, 4, -4, 3, -3, 2, -2, 1, -1, 0 };

            Console.WriteLine(String.Join(" ", numbers));

            Sort.Shuffle(numbers);
            Console.WriteLine(String.Join(" ", numbers));

            Sort.Merge(numbers);
            Console.WriteLine(String.Join(" ", numbers));



            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");

            //a = a ^ b;
            //b = a ^ b;
            //a = a ^ b;

            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");

            //if (a > b)
            //{ // XOR algorithm
            //    a = a ^ b;
            //    b = a ^ b;
            //    a = a ^ b;
            //    Console.WriteLine(a + " " + b);
            //}
            //else
            //{
            //    Console.WriteLine(a + " " + b);
            //}

        }
    }
}
