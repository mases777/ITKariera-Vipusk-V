using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList<int>();

            list.Add(42);
            list.Add(13);
            list.Add(17);

            list[0] = list[0] + 1;
            int element = list.RemoveAt(0);
            Console.WriteLine(element);
        }
    }
}
