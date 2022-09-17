using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box1 = new Box<int>();
            box1.Add(123);
            Console.WriteLine(box1);

            Box<string> box2 = new Box<string>();
            box2.Add("life in a box");
            Console.WriteLine(box2);

            Box<double> box3 = new Box<double>();
            box3.Add(3.14);
            Console.WriteLine(box3);
        }
    }
}
