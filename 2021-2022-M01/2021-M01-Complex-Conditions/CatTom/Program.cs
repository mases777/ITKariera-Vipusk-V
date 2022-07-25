using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var notWorking = n * 127;
            var working = (365 - n) * 63;
            var minutes = working + notWorking;
            if (minutes < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                var hours = (30000 - minutes) / 60;
                var min = (30000 - minutes) - hours * 60;
                Console.WriteLine($"{hours} hours and {min} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                var hours = (minutes - 30000) / 60;
                var min = (minutes - 30000) - hours * 60;
                Console.WriteLine($"{hours} hours and {min} minutes more for play");
            }
        }
    }
}
