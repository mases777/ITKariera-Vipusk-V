using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intScale = new Scale<int>(32, 41);
            Console.WriteLine(intScale.GetHavier());

            var strinScale = new Scale<string>("Ivan", "Peter");
            Console.WriteLine(strinScale.GetHavier());
        }
    }
}
