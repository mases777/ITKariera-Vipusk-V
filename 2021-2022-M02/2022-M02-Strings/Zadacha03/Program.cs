using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(StringReverse(input));
        }

        static string StringReverse(string input)
        {
            string result = String.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result = String.Concat(result, input[i].ToString());
            }
            return result;
        }
    }
}
