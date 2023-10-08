using System;
using System.Collections.Generic;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 1000 || n < 1)
            {
                n = int.Parse(Console.ReadLine());
            }
            int number = 0;
            if (n > 0)
            {
                number += n / 100;
                n -= 100 * (n / 100);
            }
            if (n > 0)
            {
                number += n / 50;
                n -= 50 * (n / 50);
            }
            if (n > 0)
            {
                number += n / 20;
                n -= 20 * (n / 20);
            }
            if (n > 0)
            {
                number += n / 10;
                n -= 10 * (n / 10);
            }
            if (n > 0)
            {
                number += n / 5;
                n -= 5 * (n / 5);
            }
            if (n > 0)
            {
                number += n / 2;
                n -= 2 * (n / 2);
            }
            if (n > 0)
            {
                number += n / 1;
                n -= 1 * (n / 1);
            }
            Console.WriteLine(number);



            //int n = int.Parse(Console.ReadLine());
            //int finalSum = n;
            //int br = 0;
            //int currentSum = 0;
            //int[] coins = { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 50, 50, 50, 20, 20, 20, 10, 10, 10, 5, 5, 5, 2, 2, 2, 1, 1, 1 };

            //Queue<int> resultCoins = new Queue<int>();

            //for (int i = 0; i < coins.Length; i++)
            //{
            //    if (currentSum + coins[i] > finalSum)
            //    {
            //        continue;
            //    }
            //    currentSum += coins[i];
            //    br++;
            //    resultCoins.Enqueue(coins[i]);
            //    if (currentSum == finalSum)
            //    {
            //        Console.WriteLine(br);
            //        return;
            //    }
            //}


        }
    }
}
