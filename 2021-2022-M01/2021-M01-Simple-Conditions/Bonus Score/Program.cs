using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (point <= 100)
            {
                bonus = 5;
            }
            else if (point <= 1000)
            {
                bonus = 0.2 * point;
            }
            else
            {
                bonus = 0.1 * point;
            }
            if (point % 2 == 0)
            {
                bonus++;
            }
            if (point % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + point);
        }
    }
}
