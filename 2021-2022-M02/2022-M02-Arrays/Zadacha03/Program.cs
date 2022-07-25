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
            /*2 3 4 5 6 1
            Min = 1
            Max = 6
            Sum = 21
            Average = 3.5*/
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int min = arr[0], max = arr[0], sum = 0;
            double average = 0.0;
            foreach (var element in arr)
            {
                if (element < min) min = element;
                if (element > max) max = element;
                sum += element;
            }
            average = 1.0 * sum / arr.Length;

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");

            Console.WriteLine(string.Join(", ", arr));

        }
    }
}
