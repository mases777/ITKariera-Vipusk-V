using System;
using System.Linq;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cities = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = cities.Length;

            int[] minFuel = new int[n];
            minFuel[0] = cities[0];
            minFuel[1] = cities[1];

            for (int i = 2; i < n; i++)
            {
                minFuel[i] = cities[i] + Math.Min(minFuel[i - 1], minFuel[i - 2]);
            }

            int result = Math.Min(minFuel[n - 1], minFuel[n - 2]);
            Console.WriteLine(result);
        }
    }
}
