using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 1 1 4 2 3 4 4 1 2 4 9 3
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] count = new int[65535];
            for (int i = 0; i< arr.Length; i++)
            {
                count[arr[i]]++;
            }
            int max = count[0], maxIndex = 0;
            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine(maxIndex);

        }
    }
}
