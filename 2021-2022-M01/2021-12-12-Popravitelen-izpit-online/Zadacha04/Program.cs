using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    class Program
    {
        static void Main(string[] args)
        {
            var friendCount = int.Parse(Console.ReadLine());

            int water = 0, fire = 0, earth = 0, air = 0;
            for (int i = 0; i < friendCount; i++)
            {
                var zodia = Console.ReadLine();
                if (zodia == "Gemini" || zodia == "Libra" || zodia == "Aquarius") air++;
                else if (zodia == "Taurus" || zodia == "Virgo" || zodia == "Capricorn") earth++;
                else if (zodia == "Aries" || zodia == "Leo" || zodia == "Sagittarius") fire++;
                else if (zodia == "Pisces" || zodia == "Cancer" || zodia == "Scorpio") water++;
            }

            Console.WriteLine($"Water: {(double)water / friendCount * 100:f2}%");
            Console.WriteLine($"Fire: {(double)fire / friendCount * 100:f2}%");
            Console.WriteLine($"Earth: {(double)earth / friendCount * 100:f2}%");
            Console.WriteLine($"Air: {(double)air / friendCount * 100:f2}%");
        }
    }
}
