using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            //minute = minute + 15;

            minute += 15;

            if (minute > 59)
            {
                //hour = hour + 1;
                //hour += 1;
                hour++;
                minute -= 60;
            }
            if (hour > 23)
            {
                hour -= 24;
            }

            if (minute < 10)
            {
                Console.WriteLine($"{hour}:0{minute}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minute}");
            }            
        }
    }
}
