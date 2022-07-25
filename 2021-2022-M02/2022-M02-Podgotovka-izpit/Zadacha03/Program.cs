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
            var words = new Dictionary<string, int>();
            string line;
            while ((line = Console.ReadLine()) != "END OF GAME")
            {
                int sum = 0;
                foreach (var item in line)
                {
                    sum += item;
                }
                if (line[0] >= 'A' && line[0] <= 'Z')
                {
                    sum += 15;
                }
                if (line[line.Length - 1] == 't')
                {
                    sum += 20;
                }
                if (line.Length >= 10)
                {
                    sum += 30;
                }
                if (words.ContainsKey(line))
                {
                    words[line] += sum;
                }
                else
                {
                    words.Add(line, sum);
                }
            }
            Console.WriteLine($"Winner is word: {words.OrderByDescending(x => x.Value).FirstOrDefault().Key}");
            Console.WriteLine($"Points: {words.Max(x => x.Value)}");
        }
    }
}
