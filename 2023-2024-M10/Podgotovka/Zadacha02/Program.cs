using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha02
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    internal class Program
    {
        public static int[,] Matrix = null;
        public static List<Point> CheckedPoints = new List<Point>();
        public static int Fires = 0;
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = nums[0];
            int m = nums[1];

            Matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                int[] rows = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < m; j++)
                {
                    Matrix[i, j] = rows[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Matrix[i,j] == 1 && !CheckedPoints.Contains(new Point(i,j)))
                    {
                        Fires++;
                        CheckSurroundings(i, j);
                    }
                }
            }
            Console.WriteLine(Fires);
        }
        private static void CheckSurroundings(int x, int y)
        {
            if (!(x >= 0 && y >= 0 && x < Matrix.GetLength(0) && y < Matrix.GetLength(1)))
            {
                return;
            }
            Point newPoint = new Point(x, y);
            if (CheckedPoints.Contains(newPoint))
            {
                return;
            }
            if (Matrix[x,y] == 1)
            {
                CheckedPoints.Add(newPoint);
                CheckSurroundings(x - 1, y - 1);
                CheckSurroundings(x - 1, y);
                CheckSurroundings(x - 1, y + 1);
                CheckSurroundings(x, y - 1);
                CheckSurroundings(x, y + 1);
                CheckSurroundings(x + 1, y - 1);
                CheckSurroundings(x + 1, y);
                CheckSurroundings(x + 1, y + 1);
            }
        }
    }
}
