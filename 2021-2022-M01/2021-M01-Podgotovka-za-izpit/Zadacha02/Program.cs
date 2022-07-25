using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    class Program
    {
        static void Main(string[] args)
        {
            int won = 0;
            int lost = 0;

            for (int i = 0; i < 3; i++)
            {
                var game = Console.ReadLine();
                if (game == "3:0" || game == "3:1" || game == "3:2")
                    won++;
                else lost++;
            }
            Console.WriteLine($"Grigor won {won} games.");
            Console.WriteLine($"Grigor lost {lost} games.");



            //var first = Console.ReadLine();
            //var second = Console.ReadLine();
            //var thirth = Console.ReadLine();

            //int won = 0;
            //int lost = 0;
            //if (first == "3:0" || first == "3:1" || first == "3:2")
            //{
            //    won++;
            //}
            //else
            //{
            //    lost++;
        }
    }
}

