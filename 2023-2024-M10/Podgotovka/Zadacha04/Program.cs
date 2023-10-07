using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha04
{
    internal class Program
    {
        static bool hasPerms = false;
        static List<string> results = new List<string>();
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            string[] perm = new string[S.Length];
            bool[] used = new bool[S.Length];
            List<string> strings = new List<string>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                strings.Add(input);
                input = Console.ReadLine();
            }

            Gen(0, S, perm, used, strings);
            if (!hasPerms)
            {
                Console.WriteLine("No permutations...");
            }
            foreach (string s in results.OrderBy(x => x))
            {
                Console.WriteLine(s);
            }
        }

        public static void Gen(int index, string[] S, string[] perm, bool[] used, List<string> strings)
        {

            if (index >= S.Length)
            {
                if (strings.Contains(string.Join("", perm)))
                {
                    results.Add(string.Join(" ", perm));
                    hasPerms = true;
                }
            }
            else
                for (int i = 0; i < S.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        perm[index] = S[i];
                        Gen(index + 1, S, perm, used, strings);
                        used[i] = false;
                    }
                }
        }
    }
}
