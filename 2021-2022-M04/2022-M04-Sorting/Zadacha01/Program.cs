﻿using System;
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
            var numbers = new int[] { 9, -9, 8, -8, 7, -7, 6, -6, 5, -5, 4, -4, 3, -3, 2, -2, 1, -1, 0 };

            Console.WriteLine(String.Join(" ", numbers));

            Sort.Shuffle(numbers);
            Console.WriteLine(String.Join(" ", numbers));

            Sort.Selection(numbers);
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
