using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Статистика_за_пасове
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> playerStats = new Dictionary<string, int>();
            char[] splitOn = new char[] { ' ', '-' };

            string input;
            while ((input = Console.ReadLine()) != "End of match")
            {
                string[] info = input
                    .Split(splitOn, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string player = info[0];
                int passes = int.Parse(info[1]);

                if (playerStats.ContainsKey(player))
                    playerStats[player] += passes;
                else playerStats[player] = passes;
            }

            foreach (KeyValuePair<string, int> player in playerStats.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key} has passed {player.Value} passes");
            }
        }
    }
}
