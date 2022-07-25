using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            for (int a = 1; a <= 9; a++)
                for (int b = 1; b <= 9; b++)
                    for (int c = 1; c <= 9; c++)
                        for (int d = 1; d <= 9; d++)
                            if (a + b == n && c % 2 == 0 && (d == 3 || d == 6))
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                br++;
                            }
            Console.WriteLine();
            Console.WriteLine($"Count of winner numbers: {br}");
        }
    }
}
