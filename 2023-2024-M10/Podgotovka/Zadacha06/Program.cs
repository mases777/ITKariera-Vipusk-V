using System;
using System.Collections.Generic;

namespace Zadacha06
{
    internal class Program
    {
        static List<int> currentSolution = new List<int>();
        public static void Permute(int ind, int n)
        {
            if (currentSolution.Count == n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{currentSolution[i]} ");
                }
                Console.WriteLine();
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                if (!currentSolution.Contains(i))
                {
                    currentSolution.Add(i);
                    Permute(ind + 1, n);
                    currentSolution.Remove(i);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 100 || n < 1)
            {
                n = int.Parse(Console.ReadLine());
            }
            Permute(0, n);
        }
    }
}
