using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());

            var result = 0.0;
            switch (type)
            {
                case "Premiere":
                    result = row * col * 12.0;
                    break;
                case "Normal":
                    result = row * col * 7.50;
                    break;
                case "Discount":
                    result = row * col * 5.0;
                    break;
            }
            Console.WriteLine($"{result:f2} leva");
        }
    }
}
