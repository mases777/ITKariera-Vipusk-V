using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();

            var result = 0.0;

            if (n < 20)
            {
                if (dayOrNight == "day")
                {
                    result = 0.70 + n * 0.79;
                }
                else
                {
                    result = 0.70 + n * 0.9;
                }
            }
            else if (n < 100)
            {
                result = n * 0.09;
            }
            else
            {
                result = n * 0.06;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
