using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1HighScores
{
    internal class Player
    {
        private string initials;
        private int score;
        public string Initials { get; set; }
        public int Score { get; set; }

        public Player(string? initials, int score)
        {
            Initials = initials;
            Score = score;
        }

        public void HighScore()
        {
            if(Score <= 0)
            {
                Console.WriteLine("Invalid Score");
            }
            else
            {
                Console.WriteLine($"Congratulations {Initials}! Your score is {Score}!\nWell done!");
            }
        }

    }
}
