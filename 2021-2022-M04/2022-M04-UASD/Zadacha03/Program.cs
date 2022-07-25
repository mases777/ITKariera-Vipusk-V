using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToList();
            var secondList = new List<int>();
            var n = int.Parse(Console.ReadLine());

            foreach (var item in firstList)
            {
                secondList.Add(item);
            }
            secondList.Add(n);
            secondList.Sort();

            Console.WriteLine(String.Join(" ", firstList));
            Console.WriteLine(String.Join(" ", secondList));
            
        }
    }
}
