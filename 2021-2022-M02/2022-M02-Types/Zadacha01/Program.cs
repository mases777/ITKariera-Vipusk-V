using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{1234} (10) = {dec2bin(1234)} (2)");
        }

        private static object dec2bin(int n)
        {
            string result = string.Empty;
            while (n > 0)
            {
                result += (n % 2);
                n /= 2;
            }
            return StringReverse(result);
        }

        private static object StringReverse(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}
