using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToList();

            var minimum = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] < minimum)
                {
                    minimum = nums[i];
                }
            }
            Console.WriteLine(minimum);
        }
    }
}
