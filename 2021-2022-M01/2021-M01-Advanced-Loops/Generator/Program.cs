using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for (int a1 = 1; a1 <= n; a1++)
                for (int a2 = 1; a2 <= n; a2++)
                    for (var a3 = 'a'; a3 < 'a' + l; a3++)
                        for (var a4 = 'a'; a4 < 'a' + l; a4++)
                            for (int a5 = Math.Max(a1, a2) + 1; a5 <= n; a5++)
                                Console.Write($"{a1}{a2}{a3}{a4}{a5} ");
            Console.WriteLine();
        }
    }
}
