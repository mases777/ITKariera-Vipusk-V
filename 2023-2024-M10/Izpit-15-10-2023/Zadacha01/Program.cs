using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            int usedIn = int.Parse(Console.ReadLine());
            List<string> priority = Console.ReadLine().Split().ToList();

            var allCombos = GetPermutations(elements, usedIn);
            var sortedCombos = new List<List<string>>();

            foreach (var combo in allCombos)
            {
                var comboList = combo.ToList();
                for (int i = priority.Count - 1; i >= 0; i--)
                {
                    int index = comboList.IndexOf(priority[i]);
                    if (index != -1)
                    {
                        var sortedCombo = new List<string>();
                        sortedCombo.Add(priority[i]);
                        comboList.RemoveAt(index);
                        sortedCombo.AddRange(comboList);
                        comboList = sortedCombo;
                    }
                }
                sortedCombos.Add(comboList);
            }

            foreach (var combo in sortedCombos)
                Console.WriteLine(string.Join(" ", combo));
        }

        static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                        yield return new T[] { item }.Concat(result);
                }

                ++i;
            }
        }
    }
}
