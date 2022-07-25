using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Rad_Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            var degrees = radians * 180 / Math.PI;            
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
