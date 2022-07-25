using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var pipe1 = p1 * h;
            var pipe2 = p2 * h;
            var totalPipe = pipe1 + pipe2;
            if (totalPipe <= v)
            {
                var full = Math.Round(totalPipe / v * 100.0);
                var pip1Percent = Math.Round(pipe1 / totalPipe * 100.0);
                var pip2Percent = Math.Round(pipe2 / totalPipe * 100.0);
                Console.WriteLine($"The pool is {full}% full. Pipe 1: {pip1Percent}%. Pipe 2: {pip2Percent}%.");
            }
            else
            {
                Console.WriteLine($"For {h} hours the pool overflows with {(totalPipe-v):f1} liters.");
            }
        }
    }
}
