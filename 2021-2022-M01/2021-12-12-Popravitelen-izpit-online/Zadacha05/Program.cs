using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 8; i++)
                for (int j = 0; j <= 9; j++)
                    for (int k = 0; k <= 9; k++)
                        for (int l = 0; l <= 5; l++)
                            if (j + k == n && (i == 1 || i == 2 || i == 8) && (l == 0 || l == 3 || l == 5))
                                Console.Write($"{i}{j}{k}{l} ");
            Console.WriteLine();

            //var n = int.Parse(Console.ReadLine());

            //int l = 1;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j <= 9; j++)
            //        for (int k = 0; k <= 9; k++)
            //            if (j + k == n)
            //                Console.Write($"{l}{j}{k}0 {l}{j}{k}3 {l}{j}{k}5 ");
            //    if (l == 1) l = 2; else if (l == 2) l = 8;
            //}
            //Console.WriteLine();


        }
    }
}
