using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberWithCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter even number: ");
                var n = int.Parse(Console.ReadLine());
                while (n % 2 == 1)
                {
                    Console.WriteLine("The number is not even.");
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Even number entered: {n}");
            }
            catch
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }
}
