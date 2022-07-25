using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftSum += num;
            }            
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            var diff = Math.Abs(leftSum - rightSum);
            if (diff == 0)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
