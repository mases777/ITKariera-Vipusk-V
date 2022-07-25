using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().ToList();
            int sum = 0;
            foreach (var item in nums)
            {
                sum += int.Parse(ReverseString(item));
            }
            Console.WriteLine(sum);
        }

        private static string ReverseString(string item)
        {
            char[] charArray = item.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
