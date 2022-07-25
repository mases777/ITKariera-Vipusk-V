using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToList();
            nums.Sort();
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join(" ", nums));
            
            if (!nums.Exists(x => x.Equals(n)))
            {
                nums.Add(n);
            }
            else
            {
                nums.Remove(n);
            }
            nums.Sort();
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
