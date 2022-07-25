using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToArray();
            var wordCounter = new Dictionary<string, int>();
            var oddCounter = new List<string>();

            foreach (var word in words)
            {
                if (wordCounter.ContainsKey(word))
                {
                    wordCounter[word]++;
                }
                else
                {
                    wordCounter[word] = 1;
                }
            }

            foreach (var item in wordCounter)
            {
                if (item.Value % 2 == 1)
                {
                    oddCounter.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddCounter));
        }
    }
}
