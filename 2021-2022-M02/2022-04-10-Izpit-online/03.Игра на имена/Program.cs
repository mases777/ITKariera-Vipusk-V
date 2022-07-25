using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Игра_на_имена
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string maxWord = "";
            int maxScore = 0;

            string input;
            while ((input = Console.ReadLine()) != "END OF GAME")
            {
                int score = ScoreWord(input);

                if (score > maxScore)
                {
                    maxScore = score;
                    maxWord = input;
                }
            }

            Console.WriteLine($"Winner is name: {maxWord}");
            Console.WriteLine($"Points: {maxScore}");
        }

        static int ScoreWord(string word)
        {
            int sum = 0;

            if (word[word.Length - 1] == 'a') sum += 10;
            if (word[word.Length - 1] == 'v') sum += 13;
            if (word.Length >= 7) sum += 33;
            else sum += 22;

            return sum;
        }
    }
}
