using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var football = new Dictionary<string, int>();
            string line;
            while ((line = Console.ReadLine()) != "End of season")
            {
                var command = line.Split('-', (char)StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = command[0];
                int points = int.Parse(command[1]);
                if (football.ContainsKey(name))
                {
                    football[name] += points;
                }
                else
                {
                    football.Add(name, points);
                }
            }
            foreach (var item in football.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
