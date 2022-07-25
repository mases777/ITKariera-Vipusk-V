using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_C_F
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsium = double.Parse(Console.ReadLine());
            var fahrenheit = celsium * 1.8 + 32;
            Console.WriteLine(fahrenheit);

        }
    }
}
