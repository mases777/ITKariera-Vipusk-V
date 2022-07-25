using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTheOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            sum -= max;
            var diff = Math.Abs(sum - max);
            if (diff == 0)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
