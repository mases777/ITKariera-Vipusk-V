using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[]
            {
                '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '
            };
            var input = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToList();
            var output = input
                .Where(x => x.Length < 5)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(String.Join(", ", output));
        }
    }
}
