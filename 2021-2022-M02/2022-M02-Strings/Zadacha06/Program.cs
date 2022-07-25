using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var timer = new Stopwatch();
            //timer.Start();
            //string result = "";
            //for (int i = 0; i < 50000; i++)
            //    result += Convert.ToString(i, 2);
            //Console.WriteLine(result.Length);
            //Console.WriteLine(timer.Elapsed);


            var timer = new Stopwatch();
            timer.Start();
            var result = new StringBuilder();
            for (int i = 0; i < 50000; i++)
                result.Append(Convert.ToString(i, 2));
            Console.WriteLine(result.Length);
            Console.WriteLine(timer.Elapsed);



        }
    }
}
