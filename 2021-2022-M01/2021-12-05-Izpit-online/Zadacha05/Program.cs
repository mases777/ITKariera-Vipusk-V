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
            //int n = int.Parse(Console.ReadLine());

            //for (int first = 0; first <= 9; first++)
            //{
            //    for (int second = 0; second <= 9; second++)
            //    {
            //        for (int third = 0; third <= 9; third++)
            //        {
            //            for (int forth = 0; forth <= 9; forth++)
            //            {
            //                bool check1 = first + forth == n;
            //                bool check2 = second % 2 == 1;
            //                bool check3 = third == 4 || third == 7;
            //                if (check1 && check2 && check3)
            //                {
            //                    Console.WriteLine($"{first}{second}{third}{forth} ");
            //                }
            //            }
            //        }
            //    }
            //}

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 9; i++)
                for (int j = 1; j <= 9; j += 2)
                    for (int k = 4; k <= 7; k += 3)
                        for (int l = 0; l <= 9; l++)
                            if (i + l == n)
                                Console.Write($"{i}{j}{k}{l} ");
            Console.WriteLine();
        }
    }
}
