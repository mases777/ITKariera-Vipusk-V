using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static long Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        static void PrintFigure(int n)
        {
            if (n == 0) // Bottom of the recursion
                return;

            // предварително действие: отпечатва n звездички
            Console.WriteLine(new string('*', n));

            // рекурсивно извикване: отпечатва фигура с размер n-1
            PrintFigure(n - 1);

            // последващо действие: отпечатва n хештаг-а # (диез)
            Console.WriteLine(new string('#', n));
        }

        static void Main(string[] args)
        {
            PrintFigure(10);
        }
    }
}
