using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToList();
            var st = new Stack<int>();
            foreach (var item in nums)
            {
                st.Push(item);
            }
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(st.Pop());
            }
        }
    }
}
