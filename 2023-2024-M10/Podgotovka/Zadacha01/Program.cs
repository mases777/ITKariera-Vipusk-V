using System;
using System.Collections.Generic;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fufu = new List<string>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                for (char j = 'a'; j <= 'z'; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    string word = i.ToString() + j.ToString();
                    fufu.Add(word);
                }
            }
            var line = Console.ReadLine();
            if (!fufu.Contains(line))
            {
                Console.WriteLine("No FuFu");
            }
            else
            {
                Console.WriteLine(fufu.IndexOf(line) + 1);
            }
        }
    }
}
