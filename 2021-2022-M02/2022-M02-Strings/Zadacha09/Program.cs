using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var template = Console.ReadLine();

            while (true)
            {
                int counter = 0;
                while (text.Contains(template))
                {
                    text = text.Remove(text.IndexOf(template), template.Length);
                    counter++;
                }
                if (counter == 0)
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                if (counter > 1)
                {
                    Console.WriteLine("Shaked it.");
                }
                template = template.Remove(template.Length / 2, 1);
            }
            Console.WriteLine(text);
        }
    }
}
