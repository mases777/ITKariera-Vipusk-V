using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            string last = "", result = "";
            for (int i = line.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(line[i]))
                {
                    if (last != "")
                    {
                        result += last;
                    }
                    else
                    {
                        result += line[i].ToString();
                    }
                }
                else
                {
                    last = line[i].ToString();
                    result += line[i].ToString();
                }
            }
            Console.WriteLine(new String(result.Reverse().ToArray()));
        }
    }
}
