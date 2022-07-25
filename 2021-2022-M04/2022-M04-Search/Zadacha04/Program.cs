using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    internal class Program
    {
        private static void MeasureTime(Action metod)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            metod();
            timer.Stop();
            Console.WriteLine($"Time = {timer.ElapsedMilliseconds} ms");
        }
        static void Main(string[] args)
        {
            int index = 0;
            int key = 54321987;
            const int n = 100000000;
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            Console.WriteLine("Linear Search for Number ...");
            MeasureTime(() => index = Search.Linear(numbers, key));
            Console.WriteLine(index == -1 ? false : true);

            Console.WriteLine("Binary Search for Number ...");
            MeasureTime(() => index = Search.Binary(numbers, key));
            Console.WriteLine(index == -1 ? false : true);

            Console.WriteLine("Interpolation Search for Number ...");
            MeasureTime(() => index = Search.InterpolationSearch(numbers, key));
            Console.WriteLine(index == -1 ? false : true);
        }
    }
}
