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
            var input = Console.ReadLine();
            var cmd = Console.ReadLine().Split(' ').ToArray();
            var sb = new StringBuilder();
            sb.Append(input);
            switch (cmd[0])
            {
                case "Append":
                    sb.Append(cmd[1]); break;
                case "Remove":
                    var pos = int.Parse(cmd[1]);
                    var number = int.Parse(cmd[2]);
                    sb.Remove(pos, number);
                    break;
                case "Insert":
                    var posi = int.Parse(cmd[1]);
                    var text = cmd[2];
                    sb.Insert(posi, text);
                    break;
                case "Replace":
                    sb.Replace(cmd[1], cmd[2]);
                    break;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
