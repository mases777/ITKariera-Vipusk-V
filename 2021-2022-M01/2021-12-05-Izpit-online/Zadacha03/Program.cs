using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var chambers = int.Parse(Console.ReadLine());
            var firm = Console.ReadLine();

            var total = width * length;
            if (chambers == 3)
            {

                if (firm == "Dogramichka4You") total *= 12;
                else if (firm == "TihoToplo") total *= 15;
                else total *= 14;
            }
            else if (chambers == 4)
            {

                if (firm == "Dogramichka4You") total *= 15;
                else if (firm == "TihoToplo") total *= 14;
                else total *= 20;
            }
            else
            {
                if (firm == "Dogramichka4You") total *= 20;
                else if (firm == "TihoToplo") total *= 18;
                else total *= 22;
            }

            Console.WriteLine($"Goshko has to spend {total:f2} leva.");
        }
    }
}
