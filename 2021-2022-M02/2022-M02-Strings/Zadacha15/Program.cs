
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            int[] min = new int[cols];
            for (int i = 0; i < cols; i++)
            {
                min[i] = matrix[0, i];
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[j,i] < min[i])
                    {
                        min[i] = matrix[j, i];
                    }
                }
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{min[j],5}");
            }
            Console.WriteLine();
        }
    }
}
