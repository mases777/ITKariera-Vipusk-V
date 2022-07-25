using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 10 == 7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (var i = 'A'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}



            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }



        }
    }
}
