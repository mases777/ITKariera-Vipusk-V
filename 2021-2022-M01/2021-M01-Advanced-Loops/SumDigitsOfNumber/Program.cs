using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
