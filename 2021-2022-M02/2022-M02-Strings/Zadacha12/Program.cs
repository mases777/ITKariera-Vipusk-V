using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var banWord = Console.ReadLine();
            string text = Console.ReadLine();
            if (text.Contains(banWord))
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }
            Console.WriteLine(text);
        }
    }
}
